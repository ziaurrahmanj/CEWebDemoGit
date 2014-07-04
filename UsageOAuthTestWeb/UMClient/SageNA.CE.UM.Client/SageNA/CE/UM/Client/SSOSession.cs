// Type: SageNA.CE.UM.Client.SSOSession
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using SageNA.CE.UMClientInterface;
using SageSSO.ServiceReferences;
using System;
using System.Web;

namespace SageNA.CE.UM.Client
{
  [Serializable]
  public class SSOSession
  {
    private static AppConfig _AppConfig = (AppConfig) null;

    public Guid SSOSessionId { get; set; }

    public string EmailAddress { get; set; }

    public string DisplayName { get; set; }

    public Guid IdentityId { get; set; }

    public string AuthenticationToken { get; set; }

    public string Culture { get; set; }

    public DateTime Expiry
    {
      get
      {
        return SSOSessionMap.GetSSOSessionExpiry(this.SSOSessionId);
      }
    }

    static SSOSession()
    {
    }

    public SSOSession(AppConfig config)
    {
      SSOSession._AppConfig = config;
    }

    public static SSOSession Current(HttpContextBase ctx)
    {
      SSOSession ssoSession = WebSessionAccessHelper.GetSSOSession(ctx);
      if (ssoSession != null && !SSOSessionMap.HasSSOSession(ssoSession.SSOSessionId))
      {
        ssoSession.End(ctx);
        ssoSession = (SSOSession) null;
      }
      return ssoSession;
    }

    public static bool HasSession(HttpContextBase ctx)
    {
      return SSOSession.Current(ctx) != null;
    }

    public static bool Refresh(HttpContextBase ctx)
    {
      bool flag = false;
      if (SSOSession.HasSession(ctx))
      {
        SSOSession ssoSession = SSOSession.Current(ctx);
        Guid ssoSessionId = ssoSession.SSOSessionId;
        if (SSOSessionMap.ShouldExtendSSOSessionOnUserActivity(ssoSessionId))
        {
          try
          {
            SessionExtendResponse sessionExtendResponse = SSOServiceCallHelper.SessionExtend(SSOSession._AppConfig, ssoSessionId, ctx.Session.Timeout);
            ssoSession.AuthenticationToken = sessionExtendResponse.UserAuthenticationToken;
            SSOSessionMap.ExtendSSOSession(ssoSessionId, sessionExtendResponse.SessionExpiry);
            SSOSessionMap.SetShouldExtendSSOSessionOnUserActivity(ssoSessionId, false);
            flag = true;
          }
          catch (Exception ex)
          {
            ssoSession.End(ctx);
          }
        }
        else
        {
          try
          {
            SSOSessionMap.RefreshSSOSession(ssoSessionId);
            flag = true;
          }
          catch (Exception ex)
          {
            ssoSession.End(ctx);
          }
        }
      }
      return flag;
    }

    public static void Start(HttpContextBase ctx, AppConfig config, Guid ssoSessionId, DateTime ssoSessionExpiry, string emailAddress, string displayName, Guid identityId, string culture, string authenticationToken)
    {
      SSOSession val = new SSOSession(config)
      {
        EmailAddress = emailAddress,
        IdentityId = identityId,
        DisplayName = displayName,
        Culture = culture,
        SSOSessionId = ssoSessionId,
        AuthenticationToken = authenticationToken
      };
      WebSessionAccessHelper.SetSSOSession(ctx, val);
      SSOSessionMap.AddSSOSession(ssoSessionId, ssoSessionExpiry, HttpContext.Current.Session.SessionID);
    }

    public void End(HttpContextBase ctx)
    {
      WebSessionAccessHelper.SetSSOSession(ctx, (SSOSession) null);
    }
  }
}
