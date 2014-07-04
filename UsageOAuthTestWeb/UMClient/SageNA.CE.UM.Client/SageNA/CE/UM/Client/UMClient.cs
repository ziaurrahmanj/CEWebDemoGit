// Type: SageNA.CE.UM.Client.UMClient
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using CEDataService;
using SageNA.CE.CEDataServiceClient;
using SageNA.CE.Common.EncryptUriSafe;
using SageNA.CE.UMClientInterface;
using SageSSO.ServiceReferences;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SageNA.CE.UM.Client
{
  public class UMClient : IUMClient
  {
    private static AppConfig _AppConfig;

    private static AppConfig AppConfig
    {
      get
      {
        if (UMClient._AppConfig == null)
          UMClient._AppConfig = ConfigHelper.DefaultConfig;
        return UMClient._AppConfig;
      }
    }

    internal static ICEUMRepository UMRepositoryClient
    {
      get
      {
        SSOServiceCallHelper.InitServicePointManager();
        return (ICEUMRepository) new CEUMRepositoryClient(UMClient.AppConfig.RepositoryEndPointConfig);
      }
    }

    public UMClient()
    {
      UMClient._AppConfig = ConfigHelper.DefaultConfig;
    }

    public UMClient(AppConfig appConfig)
    {
      UMClient._AppConfig = appConfig;
    }

    public Uri StartSignOn(Controller ctrl)
    {
      TraceHelper.TraceLog(ctrl, "StartSignOn", new object[0]);
      StartSignOnAttemptResponse onAttemptResponse;
      try
      {
        string successUri = string.Format("{0}/{{0}}", (object) UriHelper.ToAbsoluteUri(UMClient.AppConfig, ctrl.HttpContext, ctrl.Url.RouteUrl("SignOnSuccess", (RouteValueDictionary) null)).AbsoluteUri);
        string failureUri = string.Format("{0}/{{0}}", (object) UriHelper.ToAbsoluteUri(UMClient.AppConfig, ctrl.HttpContext, ctrl.Url.RouteUrl("SignOnFail", (RouteValueDictionary) null)).AbsoluteUri);
        bool cancelAllowed = true;
        int sessionTimeoutMinutes = UMClient.AppConfig.SessionTimeoutMinutes;
        string templateName = this.IsMobileClient() ? UMClient.AppConfig.MobileTemplate : UMClient.AppConfig.DefaultTemplate;
        TraceHelper.TraceLog(ctrl, "StartSignOn call", (object) successUri, (object) failureUri, (object) (bool) (cancelAllowed ? 1 : 0), (object) sessionTimeoutMinutes, (object) templateName);
        onAttemptResponse = SSOServiceCallHelper.StartSignOnAttempt(UMClient.AppConfig, successUri, failureUri, cancelAllowed, sessionTimeoutMinutes, templateName);
        TraceHelper.TraceLog(ctrl, "StartSignOn response", new object[1]
        {
          (object) onAttemptResponse
        });
        ISSOState ssoState = WebSessionAccessHelper.GetSSOState(ctrl.HttpContext);
        ssoState.SignOnAttempt = onAttemptResponse.SignOnAttemptId;
        WebSessionAccessHelper.SetSSOState(ctrl.HttpContext, ssoState);
      }
      catch (Exception ex)
      {
        TraceHelper.TraceLog(ctrl, "StartSignOn error", new object[1]
        {
          (object) ex
        });
        throw;
      }
      return new Uri(onAttemptResponse.RedirectUri);
    }

    public UserSignOnResult GetSignOnInfo(Controller ctrl, string signOnResult)
    {
      TraceHelper.TraceLog(ctrl, "GetSignOnInfo", new object[1]
      {
        (object) signOnResult
      });
      UserSignOnResult authInfo = WebSessionAccessHelper.GetSSOState(ctrl.HttpContext).AuthInfo;
      TraceHelper.TraceLog(ctrl, "GetSignOnInfo GetSSOState", new object[1]
      {
        (object) authInfo
      });
      Guid result;
      if (Guid.TryParse(signOnResult, out result))
      {
        try
        {
          if (result != Guid.Empty)
          {
            TraceHelper.TraceLog(ctrl, "GetSignOnInfo EndSignOnAttempt", new object[0]);
            EndSignOnAttemptResponse onAttemptResponse = SSOServiceCallHelper.EndSignOnAttempt(UMClient.AppConfig, result);
            UMClient.ProcessSuccessResult(ctrl, authInfo, onAttemptResponse.Culture, onAttemptResponse.Item);
          }
          else
          {
            TraceHelper.TraceLog(ctrl, "GetSignOnInfo GetSSOState", new object[0]);
            ISSOState ssoState = WebSessionAccessHelper.GetSSOState(ctrl.HttpContext);
            TraceHelper.TraceLog(ctrl, "GetSignOnInfo GetSSOState", new object[1]
            {
              (object) ssoState
            });
            UMClient.ProcessSuccessResult(ctrl, authInfo, Enumerable.FirstOrDefault<string>((IEnumerable<string>) ctrl.HttpContext.Request.UserLanguages), ssoState.Result);
          }
        }
        catch (Exception ex)
        {
          TraceHelper.TraceLog(ctrl, "GetSignOnInfo error", new object[1]
          {
            (object) ex
          });
          authInfo.IsValid = false;
          authInfo.SignOnInfoText = string.Format("Exception of type {0} raised during GetSignOnInfo. {1}", (object) ex.GetType().FullName, (object) ex.Message);
          authInfo.IsAuthoritative = true;
        }
      }
      else
      {
        TraceHelper.TraceLog(ctrl, "GetSignOnInfo invalid Guid", new object[1]
        {
          (object) signOnResult
        });
        authInfo.IsValid = false;
        authInfo.SignOnInfoText = "Unable to authenticate user.";
        authInfo.IsAuthoritative = true;
      }
      TraceHelper.TraceLog(ctrl, "GetSignOnInfo return", new object[1]
      {
        (object) authInfo
      });
      return authInfo;
    }

    private static void ProcessSuccessResult(Controller ctrl, UserSignOnResult ret, string culture, object result)
    {
      TraceHelper.TraceLog(ctrl, "ProcessSuccessResult", new object[1]
      {
        result
      });
      if (result != null && result is SuccessResult)
      {
        SuccessResult successResult = (SuccessResult) result;
        Controller controller = ctrl;
        string message = "ProcessSuccessResult StartWebSession";
        object[] objArray1 = new object[5]
        {
          (object) UMClient.AppConfig.ProductId,
          (object) UMClient.AppConfig.ApplicationId,
          (object) successResult.IdentityId,
          null,
          null
        };
        object[] objArray2 = objArray1;
        int index = 3;
        Guid sessionId1 = successResult.SessionId;
        string str = sessionId1.ToString();
        objArray2[index] = (object) str;
        objArray1[4] = (object) true;
        object[] objArray3 = objArray1;
        TraceHelper.TraceLog(controller, message, objArray3);
        UserSignOnResult userSignOnResult = ret;
        ICEUMRepository repositoryClient = UMClient.UMRepositoryClient;
        Guid productId = UMClient.AppConfig.ProductId;
        Guid appId = UMClient.AppConfig.ApplicationId;
        Guid identityId = successResult.IdentityId;
        sessionId1 = successResult.SessionId;
        string sessionId2 = sessionId1.ToString();
        int num = 1;
        PersonAccessInfo personAccessInfo = repositoryClient.StartWebSession(productId, appId, identityId, sessionId2, num != 0);
        userSignOnResult.User = personAccessInfo;
        ret.IsValid = Enumerable.Count<AppUserAccess>((IEnumerable<AppUserAccess>) ret.User.AppUserAccessInfo) > 0;
        ret.IsAuthoritative = true;
        if (!ret.IsValid)
        {
          ret.Reason = ReasonCode.EntitlementValidationFailure;
          ret.SignOnInfoText = "User is not entitled to access requested application.";
        }
        else
        {
          TraceHelper.TraceLog(ctrl, "ProcessSuccessResult SSOSession.Start", (object) successResult.SessionId, (object) successResult.SessionExpiry, (object) successResult.EmailAddress, (object) successResult.DisplayName, (object) successResult.IdentityId, (object) culture, (object) successResult.UserAuthenticationToken);
          SSOSession.Start(ctrl.HttpContext, UMClient.AppConfig, successResult.SessionId, successResult.SessionExpiry, successResult.EmailAddress, successResult.DisplayName, successResult.IdentityId, culture, successResult.UserAuthenticationToken);
        }
      }
      else
      {
        ret.IsValid = false;
        ret.SignOnInfoText = "Unable to authenticate user.";
        ret.IsAuthoritative = true;
      }
      TraceHelper.TraceLog(ctrl, "ProcessSuccessResult return ", new object[1]
      {
        (object) ret
      });
    }

    public Uri EndSession(Controller ctrl)
    {
      TraceHelper.TraceLog(ctrl, "EndSession", new object[0]);
      Guid ssoSessionId = Guid.Empty;
      if (SSOSession.HasSession(ctrl.HttpContext))
      {
        TraceHelper.TraceLog(ctrl, "EndSession HasSession=true", new object[0]);
        SSOSession ssoSession = SSOSession.Current(ctrl.HttpContext);
        ssoSessionId = ssoSession.SSOSessionId;
        TraceHelper.TraceLog(ctrl, "EndSession Session.End", new object[1]
        {
          (object) ssoSession
        });
        ssoSession.End(ctrl.HttpContext);
        try
        {
          TraceHelper.TraceLog(ctrl, "UMRepositoryClient.EndWebSession", new object[1]
          {
            (object) ssoSession
          });
          UMClient.UMRepositoryClient.EndWebSession(ssoSessionId.ToString());
        }
        catch (Exception ex)
        {
          TraceHelper.TraceLog(ctrl, "EndSession EndWebSession error", new object[1]
          {
            (object) ex
          });
        }
      }
      TraceHelper.TraceLog(ctrl, "EndSession Session.Abandon", new object[0]);
      ctrl.Session.Abandon();
      if (ssoSessionId != Guid.Empty)
      {
        try
        {
          TraceHelper.TraceLog(ctrl, "EndSession SessionRemoveParticipant", new object[1]
          {
            (object) ssoSessionId
          });
          SSOServiceCallHelper.SessionRemoveParticipant(UMClient.AppConfig, ssoSessionId);
        }
        catch (Exception ex)
        {
          TraceHelper.TraceLog(ctrl, "EndSession SessionRemoveParticipant error", new object[1]
          {
            (object) ex
          });
          throw new Exception("Unable to end the current session.", ex);
        }
      }
      Uri uri = UriHelper.ToAbsoluteUri(UMClient.AppConfig, ctrl.HttpContext, ctrl.Url.Action("SignOnInit", "SSO"));
      TraceHelper.TraceLog(ctrl, "EndSession return", new object[1]
      {
        (object) uri
      });
      return uri;
    }

    public Uri StartProvisioningAndAdminSignup(Controller controller, string activationReference)
    {
      throw new NotImplementedException();
    }

    public Uri StartUserSignup(Controller ctrl, string emailReference)
    {
      TraceHelper.TraceLog(ctrl, "StartUserSignup", new object[1]
      {
        (object) emailReference
      });
      Uri uri = (Uri) null;
      CryptoAgent cryptoAgent = new CryptoAgent(UMClient.AppConfig.ProductId);
      NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(cryptoAgent.Decrypt(emailReference));
      string str = nameValueCollection["Email"];
      Guid productUserId = new Guid(nameValueCollection["ProductUserId"]);
      bool confirmed;
      PersonAccessInfo pai;
      Guid sageUserIdentity;
      SageIdAccountStatus userIdentityStatus = UMClient.GetUserIdentityStatus(UMClient.AppConfig, ctrl, UMClient.AppConfig.ProductId, UMClient.AppConfig.ApplicationId, str, out confirmed, out pai, out sageUserIdentity);
      TraceHelper.TraceLog(ctrl, "StartUserSignUp GetSSOState", new object[0]);
      ISSOState ssoState = WebSessionAccessHelper.GetSSOState(ctrl.HttpContext);
      TraceHelper.TraceLog(ctrl, "StartUserSignUp GetSSOState returns", new object[1]
      {
        (object) ssoState
      });
      switch (userIdentityStatus)
      {
        case SageIdAccountStatus.DoesNotExist:
          TraceHelper.TraceLog(ctrl, "StartUserSignUp UMRepositoryClient.StartUserInvitation", new object[1]
          {
            (object) productUserId
          });
          PersonAccessInfo personAccessInfo = UMClient.UMRepositoryClient.StartUserInvitation(productUserId);
          TraceHelper.TraceLog(ctrl, "StartUserSignUp UMRepositoryClient.StartUserInvitation returns", new object[1]
          {
            (object) personAccessInfo
          });
          ssoState.AuthInfo.User = personAccessInfo;
          ssoState.RegistrationProductUserId = productUserId;
          uri = UriHelper.ToAbsoluteUri(UMClient.AppConfig, ctrl.HttpContext, ctrl.Url.Action("RegisterNew", "SSO"));
          break;
        case SageIdAccountStatus.ExistsNotActive:
          if (pai == null || pai.PersonInfo == null || !string.Equals(pai.PersonInfo.PrimaryEmail, str, StringComparison.InvariantCultureIgnoreCase))
          {
            TraceHelper.TraceLog(ctrl, "StartUserSignUp error - The invitation used is no longer valid. Please contact your administrator to get re-invited.", new object[0]);
            throw new Exception("The invitation used is no longer valid. Please contact your administrator to get re-invited.");
          }
          else if (UMClient.AppConfig.UsesAutoRegistration)
          {
            TraceHelper.TraceLog(ctrl, "StartUserSignUp AssociateUser", (object) UMClient.AppConfig.ProductId, (object) sageUserIdentity);
            UMClient.UMRepositoryClient.AssociateUser(pai.ProductUserId, sageUserIdentity);
            TraceHelper.TraceLog(ctrl, "StartUserSignUp AssociateUser returns", new object[0]);
            if (!confirmed)
              UMClient.UMRepositoryClient.ConfirmUser(productUserId);
            uri = this.StartSignOn(ctrl);
            break;
          }
          else
          {
            ssoState.RegistrationProductUserId = productUserId;
            uri = UriHelper.ToAbsoluteUri(UMClient.AppConfig, ctrl.HttpContext, ctrl.Url.Action("RegisterExisting", "SSO", (object) cryptoAgent.Encrypt(sageUserIdentity.ToString())));
            break;
          }
        case SageIdAccountStatus.ExistsAndActive:
          if (!confirmed)
            UMClient.UMRepositoryClient.ConfirmUser(productUserId);
          uri = this.StartSignOn(ctrl);
          break;
      }
      TraceHelper.TraceLog(ctrl, "StartUserSignUp SetSSOState", new object[0]);
      WebSessionAccessHelper.SetSSOState(ctrl.HttpContext, ssoState);
      TraceHelper.TraceLog(ctrl, "StartUserSignUp returns", new object[1]
      {
        (object) uri
      });
      return uri;
    }

    private bool IsMobileClient()
    {
      return new Regex("android|blackberry|ip(hone|od)|windows (ce|phone)", RegexOptions.IgnoreCase | RegexOptions.Multiline).IsMatch(HttpContext.Current.Request.ServerVariables["HTTP_USER_AGENT"]);
    }

    internal static SageIdAccountStatus GetUserIdentityStatus(AppConfig appConfig, Controller ctrl, Guid productId, Guid appId, string email, out bool confirmed, out PersonAccessInfo pai, out Guid sageUserIdentity)
    {
      ListUserIdentitiesResponse identitiesResponse = SSOServiceCallHelper.ListUserIdentities(appConfig, email);
      SageIdAccountStatus sageIdAccountStatus;
      if (Enumerable.Count<UserIdentity>((IEnumerable<UserIdentity>) identitiesResponse.UserIdentities) == 0)
      {
        pai = (PersonAccessInfo) null;
        sageUserIdentity = Guid.Empty;
        sageIdAccountStatus = SageIdAccountStatus.DoesNotExist;
        confirmed = false;
      }
      else
      {
        sageUserIdentity = identitiesResponse.UserIdentities[0].Id;
        TraceHelper.TraceLog(ctrl, "StartUserSignUp GetAccessInfoByEmail", (object) UMClient.AppConfig.ProductId, (object) UMClient.AppConfig.ApplicationId, (object) email, (object) false);
        pai = UMClient.UMRepositoryClient.GetAccessInfoByEmail(productId, appId, email, false);
        TraceHelper.TraceLog(ctrl, "StartUserSignUp GetAccessInfoByEmail returns", new object[1]
        {
          (object) pai
        });
        sageIdAccountStatus = pai.PersonInfo.IsSageIdAssociated ? SageIdAccountStatus.ExistsAndActive : SageIdAccountStatus.ExistsNotActive;
        confirmed = pai.Confirmed;
      }
      return sageIdAccountStatus;
    }
  }
}
