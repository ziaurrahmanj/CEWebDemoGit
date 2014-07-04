// Type: SageNA.CE.UM.Client.WebSessionAccessHelper
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using SageNA.CE.UMClientInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SageNA.CE.UM.Client
{
  internal static class WebSessionAccessHelper
  {
    private const string _SSOSessionKey = "SSOSession";
    private const string _SSOOriginalRequestKey = "SSOOriginalRequest";
    private const string _SSOStateKey = "SSOState";
    private const string _SessionInaccessible = "The session context is currently unavailable.";

    internal static SSOSession GetSSOSession(HttpContextBase ctx)
    {
      WebSessionAccessHelper.ValidateContextPrereq(ctx);
      object obj = ctx.Session["SSOSession"];
      return obj != null && !(obj.GetType() != typeof (SSOSession)) ? (SSOSession) obj : (SSOSession) null;
    }

    internal static void SetSSOSession(HttpContextBase ctx, SSOSession val)
    {
      WebSessionAccessHelper.ValidateContextPrereq(ctx);
      ctx.Session["SSOSession"] = (object) val;
    }

    internal static string GetSSOOriginalRequestUrl(HttpContextBase ctx)
    {
      WebSessionAccessHelper.ValidateContextPrereq(ctx);
      object obj = ctx.Session["SSOOriginalRequest"];
      string str;
      if (obj == null || obj.GetType() != typeof (string))
      {
        str = string.Empty;
        ctx.Session["SSOOriginalRequest"] = (object) str;
      }
      else
        str = (string) obj;
      return str;
    }

    internal static void SetSSOOriginalRequestUrl(HttpContextBase ctx, string val)
    {
      WebSessionAccessHelper.ValidateContextPrereq(ctx);
      ctx.Session["SSOOriginalRequest"] = (object) val;
      ISSOState ssoState = WebSessionAccessHelper.GetSSOState(ctx);
      ssoState.AuthInfo.OriginalRequestUrl = val;
      WebSessionAccessHelper.SetSSOState(ctx, ssoState);
    }

    internal static ISSOState GetSSOState(HttpContextBase ctx)
    {
      WebSessionAccessHelper.ValidateContextPrereq(ctx);
      object obj = ctx.Session["SSOState"];
      ISSOState ssoState;
      if (obj == null || !Enumerable.Contains<Type>((IEnumerable<Type>) obj.GetType().GetInterfaces(), typeof (ISSOState)))
      {
        ssoState = (ISSOState) new SSOState();
        ctx.Session["SSOState"] = (object) ssoState;
      }
      else
        ssoState = (ISSOState) obj;
      return ssoState;
    }

    internal static void SetSSOState(HttpContextBase ctx, ISSOState val)
    {
      WebSessionAccessHelper.ValidateContextPrereq(ctx);
      ctx.Session["SSOState"] = (object) val;
    }

    internal static void SetSSOMessageResult(HttpContextBase ctx, string message, OAuthReasonCode oAuthReason)
    {
      ISSOState ssoState = WebSessionAccessHelper.GetSSOState(ctx);
      ssoState.Message = message;
      ssoState.AuthInfo.OAuthReason = oAuthReason;
      if (oAuthReason != OAuthReasonCode.OAuthNA)
        ssoState.AuthInfo.IsValid = oAuthReason == OAuthReasonCode.OAuthOK;
      ssoState.AuthInfo.SignOnInfoText = message;
      WebSessionAccessHelper.SetSSOState(ctx, ssoState);
    }

    internal static void SetSSOMessageResult(HttpContextBase ctx, string message, ReasonCode reasonCode)
    {
      ISSOState ssoState = WebSessionAccessHelper.GetSSOState(ctx);
      ssoState.Message = message;
      ssoState.SignOnFailureReason = reasonCode;
      if (reasonCode != ReasonCode.None)
        ssoState.AuthInfo.IsValid = reasonCode == ReasonCode.OK;
      ssoState.AuthInfo.SignOnInfoText = message;
      ssoState.AuthInfo.Reason = reasonCode;
      WebSessionAccessHelper.SetSSOState(ctx, ssoState);
    }

    internal static void Reset(HttpContextBase ctx)
    {
      WebSessionAccessHelper.SetSSOState(ctx, (ISSOState) null);
      WebSessionAccessHelper.SetSSOOriginalRequestUrl(ctx, string.Empty);
      WebSessionAccessHelper.SetSSOMessageResult(ctx, string.Empty, ReasonCode.ProtocolViolation);
    }

    private static void ValidateContextPrereq(HttpContextBase ctx)
    {
      if (ctx == null || ctx.Session == null)
        throw new Exception("The session context is currently unavailable.");
    }
  }
}
