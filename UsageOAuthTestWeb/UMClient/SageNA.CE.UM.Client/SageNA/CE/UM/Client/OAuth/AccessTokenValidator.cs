// Type: SageNA.CE.UM.Client.OAuth.AccessTokenValidator
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using Sage.Obsidian.Shared.Schema;
using SageNA.CE.UM.Client;
using SageNA.CE.UMClientInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace SageNA.CE.UM.Client.OAuth
{
  public class AccessTokenValidator
  {
    private AppConfig _Configuration;
    private X509Certificate2 _SageIdRootCert;

    public AccessTokenValidator(AppConfig config)
    {
      this._Configuration = config;
      this._SageIdRootCert = CertificateHelper.GetCertificateFromFindCriteria(this._Configuration.RootCertificateFindType, this._Configuration.RootCertificateFindValue);
    }

    public TokenValidationStatus ExtractToken(HttpRequest httpRequest, out string tokenValue, out string errorMessage)
    {
      tokenValue = TokenUtil.ExtractBearerToken(out errorMessage, httpRequest);
      return string.IsNullOrEmpty(tokenValue) ? TokenValidationStatus.FailNoBearerToken : TokenValidationStatus.Success;
    }

    public TokenValidationStatus ValidateToken(string tokenValue, out Guid sageIdentityId, out DateTime validUntil, out string permissionDescription, out string errorMessage)
    {
      AuthenticationToken token = TokenUtil.BuildAuthenticationToken(this._Configuration.EncryptionKey, this._Configuration.InitializationVector, this._SageIdRootCert, tokenValue, true, out errorMessage);
      TokenValidationStatus validationStatus;
      if (token == null)
      {
        sageIdentityId = Guid.Empty;
        validUntil = DateTime.UtcNow;
        permissionDescription = string.Empty;
        validationStatus = TokenValidationStatus.FailTokenDeserialize;
      }
      else
      {
        sageIdentityId = token.get_Subject().get_Item().get_Id();
        validUntil = token.get_Scope().get_Validity().get_NotValidAfter();
        permissionDescription = AccessTokenValidator.ExtractPermisssionDescription(token);
        validationStatus = AccessTokenValidator.ValidateToken(token, this._Configuration.ServerTimeAdjustmentGracePeriodSeconds);
      }
      return validationStatus;
    }

    public TokenValidationStatus ValidateTokenResourceAccess(string tokenValue, string resource, string action, out string errorMessage)
    {
      if (Enumerable.Any<Permission>(Enumerable.Where<Permission>((IEnumerable<Permission>) TokenUtil.BuildAuthenticationToken(this._Configuration.EncryptionKey, this._Configuration.InitializationVector, this._SageIdRootCert, tokenValue, true, out errorMessage).get_Scope().get_Permissions(), (Func<Permission, bool>) (p => StringComparer.CurrentCultureIgnoreCase.Compare(p.get_Resource(), resource) == 0 && StringComparer.CurrentCultureIgnoreCase.Compare(p.get_Action(), action) == 0))))
        return TokenValidationStatus.Success;
      errorMessage = "The token does not contain the required privilege.";
      return TokenValidationStatus.FailNoResourceAccess;
    }

    private static TokenValidationStatus ValidateToken(AuthenticationToken token, int serverTimeAdjustmentGracePeriodSeconds)
    {
      if (!(token.get_Subject().get_Item() is UserPrincipal))
        return TokenValidationStatus.FailUserPrincipal;
      if (!(token.get_Scope().get_Bearer().get_Item() is SecretkeyPrincipal) && !(token.get_Scope().get_Bearer().get_Item() is X509Principal))
        return TokenValidationStatus.FailSecretkeyPrincipal;
      if (DateTime.UtcNow.Add(TimeSpan.FromSeconds((double) serverTimeAdjustmentGracePeriodSeconds)) < token.get_Scope().get_Validity().get_NotValidBefore())
        return TokenValidationStatus.FailTokenNotYetValid;
      return token.get_Scope().get_Validity().get_NotValidAfter().Add(TimeSpan.FromSeconds((double) serverTimeAdjustmentGracePeriodSeconds)) < DateTime.UtcNow ? TokenValidationStatus.FailTokenExpired : TokenValidationStatus.Success;
    }

    private static string ExtractPermisssionDescription(AuthenticationToken token)
    {
      string str;
      try
      {
        str = string.Join(";", Enumerable.ToArray<string>(Enumerable.Select<Permission, string>((IEnumerable<Permission>) token.get_Scope().get_Permissions(), (Func<Permission, string>) (p => string.Format("A={0},Op={1}", (object) p.get_Action(), (object) p.get_Resource())))));
      }
      catch (Exception ex)
      {
        str = string.Empty;
      }
      return str;
    }
  }
}
