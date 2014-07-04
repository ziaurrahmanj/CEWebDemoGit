// Type: SageNA.CE.UM.Client.UMOAuth
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using CEDataService;
using SageNA.CE.CEDataServiceClient;
using SageNA.CE.UM.Client.OAuth;
using SageNA.CE.UMClientInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace SageNA.CE.UM.Client
{
  public class UMOAuth : IUMOAuth
  {
    private AppConfig _AppConfig;
    private CacheManager _CacheManager;
    private AccessTokenValidator _TokenValidator;
    private CEUMRepositoryClient _RepositoryClient;

    public UMOAuth(AppConfig config)
    {
      this.InitFromConfig(config);
    }

    public UMOAuth()
    {
      this.InitFromConfig(ConfigHelper.DefaultConfig);
    }

    public UserSignOnResult GetOAuthInfo(string oAuthTokenBase64, bool requestAuthoritativeAnswer)
    {
      UserSignOnResult userSignOnResult = (UserSignOnResult) null;
      try
      {
        object retVal;
        if (!requestAuthoritativeAnswer && this._CacheManager.IsActive)
        {
          retVal = (object) null;
          if (this._CacheManager.Load(oAuthTokenBase64, out retVal) && retVal != null)
            userSignOnResult = (UserSignOnResult) retVal;
        }
        if (userSignOnResult == null)
        {
          Guid sageIdentityId;
          DateTime validUntil;
          string permissionDescription;
          string errorMessage;
          TokenValidationStatus status = this._TokenValidator.ValidateToken(oAuthTokenBase64, out sageIdentityId, out validUntil, out permissionDescription, out errorMessage);
          if (status == TokenValidationStatus.Success)
          {
            try
            {
              PersonAccessInfo infoBySageIdOauth = this._RepositoryClient.GetAccessInfoBySageIdOAuth(this._AppConfig.ProductId, this._AppConfig.ApplicationId, sageIdentityId, permissionDescription, true);
              if (Enumerable.Count<AppUserAccess>((IEnumerable<AppUserAccess>) infoBySageIdOauth.AppUserAccessInfo) > 0)
                userSignOnResult = new UserSignOnResult()
                {
                  User = infoBySageIdOauth,
                  IsValid = true,
                  Reason = ReasonCode.OK,
                  OAuthReason = OAuthReasonCode.OAuthOK,
                  SignOnInfoText = "OK",
                  IsAuthoritative = true
                };
              else
                userSignOnResult = new UserSignOnResult()
                {
                  User = infoBySageIdOauth,
                  IsValid = false,
                  Reason = ReasonCode.EntitlementValidationFailure,
                  OAuthReason = OAuthReasonCode.OAuthForbidden,
                  SignOnInfoText = "User is not entitled.",
                  IsAuthoritative = true
                };
              retVal = (object) userSignOnResult;
              this._CacheManager.Store(oAuthTokenBase64, retVal, validUntil);
            }
            catch (Exception ex)
            {
              userSignOnResult = new UserSignOnResult()
              {
                IsValid = false,
                Reason = ReasonCode.ProtocolViolation,
                OAuthReason = OAuthReasonCode.OAuthInternalError,
                SignOnInfoText = string.Format("Unable to authorize user. Exception of type {0} - {1}.", (object) ex.GetType().FullName, (object) ex.Message),
                IsAuthoritative = true
              };
            }
          }
          else
            userSignOnResult = new UserSignOnResult()
            {
              IsValid = false,
              Reason = ReasonCode.ValidationFailed,
              OAuthReason = TokenValidationStatusMapper.ValidationStatusToReasonCode(status),
              SignOnInfoText = errorMessage,
              IsAuthoritative = true
            };
        }
      }
      catch (Exception ex)
      {
        userSignOnResult = new UserSignOnResult()
        {
          IsValid = false,
          Reason = ReasonCode.ProtocolViolation,
          OAuthReason = OAuthReasonCode.OAuthInternalError,
          SignOnInfoText = ex.Message,
          IsAuthoritative = true
        };
      }
      return userSignOnResult;
    }

    public UserSignOnResult GetOAuthInfo(HttpRequest request, bool requestAuthoritativeAnswer)
    {
      UserSignOnResult userSignOnResult;
      try
      {
        string tokenValue;
        string errorMessage;
        TokenValidationStatus token = this._TokenValidator.ExtractToken(request, out tokenValue, out errorMessage);
        if (token == TokenValidationStatus.Success && tokenValue != null)
          userSignOnResult = this.GetOAuthInfo(tokenValue, requestAuthoritativeAnswer);
        else
          userSignOnResult = new UserSignOnResult()
          {
            IsValid = false,
            IsAuthoritative = true,
            SignOnInfoText = errorMessage,
            Reason = ReasonCode.ValidationFailed,
            OAuthReason = TokenValidationStatusMapper.ValidationStatusToReasonCode(token)
          };
      }
      catch (Exception ex)
      {
        userSignOnResult = new UserSignOnResult()
        {
          IsValid = false,
          Reason = ReasonCode.ProtocolViolation,
          OAuthReason = OAuthReasonCode.OAuthInternalError,
          SignOnInfoText = ex.Message,
          IsAuthoritative = true
        };
      }
      return userSignOnResult;
    }

    public HttpResponseMessage GetDefaultErrorResponse(UserSignOnResult authResult)
    {
      return new HttpResponseMessage()
      {
        StatusCode = (HttpStatusCode) authResult.OAuthReason,
        ReasonPhrase = ((object) authResult.Reason).ToString(),
        Content = (HttpContent) new StringContent(authResult.SignOnInfoText)
      };
    }

    private void InitFromConfig(AppConfig config)
    {
      this._AppConfig = config;
      this._CacheManager = CacheManager.Instance;
      this._TokenValidator = new AccessTokenValidator(this._AppConfig);
      this._RepositoryClient = new CEUMRepositoryClient(this._AppConfig.RepositoryEndPointConfig);
    }
  }
}
