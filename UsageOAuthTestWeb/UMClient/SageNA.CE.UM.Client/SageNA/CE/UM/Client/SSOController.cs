// Type: SageNA.CE.UM.Client.SSOController
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using CEDataService;
using SageNA.CE.UMClientInterface;
using SageSSO.ServiceReferences;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;

namespace SageNA.CE.UM.Client
{
  public class SSOController : Controller
  {
    private static AppConfig _AppConfig = (AppConfig) null;
    private const int MaxNotificationSize = 8192;
    private const string CachedIdFormat = "NotificationId_{0}";

    private static AppConfig AppConfig
    {
      get
      {
        if (SSOController._AppConfig == null)
          SSOController._AppConfig = ConfigHelper.DefaultConfig;
        return SSOController._AppConfig;
      }
      set
      {
        SSOController._AppConfig = value;
      }
    }

    static SSOController()
    {
    }

    [AcceptVerbs(HttpVerbs.Get)]
    public ActionResult Activation(string resultId)
    {
      ReasonCode reasonCode = ReasonCode.ProtocolViolation;
      string message = string.Empty;
      Guid result;
      if (Guid.TryParse(resultId, out result) && result != Guid.Empty)
      {
        try
        {
          WebSessionAccessHelper.GetSSOState(this.HttpContext);
          Dictionary<string, string> dictionary = SSOServiceCallHelper.ContextToDict(SSOServiceCallHelper.ActivationLinkContext(SSOController.AppConfig, result));
          if (dictionary["Handler"] == "WebSSO/Registration")
          {
            if (dictionary["Result"] == "Activated")
            {
              reasonCode = ReasonCode.OK;
              message = string.Format("Account activated for user identity {0}", (object) dictionary["IdentityId"]);
            }
            else
            {
              reasonCode = ReasonCode.AccountNotActivated;
              message = string.Format("The activation link was expired.", new object[0]);
            }
          }
          else if (dictionary["Handler"] == "WebSSO/PasswordActivation")
          {
            if (dictionary["Result"] == "PasswordChanged")
            {
              string.Format("Password changed for user identity {0}", (object) dictionary["IdentityId"]);
              return this.RedirectToPasswordResetSuccessAction();
            }
            else
            {
              reasonCode = ReasonCode.AccountNotActivated;
              message = string.Format("The activation link was expired.", new object[0]);
            }
          }
        }
        catch (Exception ex)
        {
          reasonCode = ReasonCode.ProtocolViolation;
          message = string.Format("Exception of type {0} raised when calling WebSSOService.ActivationLinkContext(). {1}", (object) ex.GetType().FullName, (object) ex.Message);
        }
      }
      WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, message, reasonCode);
      return (ActionResult) this.Redirect(this.LogonResultUrl(Guid.Empty));
    }

    private ActionResult RedirectToPasswordResetSuccessAction()
    {
      Uri uri = new Uri(UMClient.UMRepositoryClient.GetUserAdminAppUrl());
      return (ActionResult) this.Redirect(new UriBuilder(uri.Scheme, uri.Host, uri.Port, "/home/passwordresetsuccess").Uri.AbsoluteUri);
    }

    [AcceptVerbs(HttpVerbs.Get)]
    public ActionResult RegisterNew()
    {
      StartRegistrationAttemptResponse registrationAttemptResponse;
      try
      {
        ISSOState ssoState = WebSessionAccessHelper.GetSSOState(this.HttpContext);
        Uri resultUri = UriHelper.ToAbsoluteUri(SSOController.AppConfig, this.HttpContext, string.Format("{0}/{{0}}", (object) this.Url.Action("RegisterNewResult", "SSO")));
        Person personInfo = ssoState.AuthInfo.User.PersonInfo;
        string primaryEmail = personInfo.PrimaryEmail;
        string displayName = FormatHelper.StructuredToCompoundName(personInfo.FirstName, personInfo.MiddleName, personInfo.LastName);
        registrationAttemptResponse = SSOServiceCallHelper.StartNewUserRegistrationAttempt(SSOController.AppConfig, resultUri, primaryEmail, displayName, this.HttpContext.Session.Timeout, true);
        ssoState.NewUserRegistrationAttempt = registrationAttemptResponse.RegistrationAttemptId;
        WebSessionAccessHelper.SetSSOState(this.HttpContext, ssoState);
      }
      catch (Exception ex)
      {
        WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, string.Format("Exception of type {0} raised when calling WebSSOService.StartNewUserRegistrationAttempt(). {1}", (object) ex.GetType().FullName, (object) ex.Message), ReasonCode.ProtocolViolation);
        return (ActionResult) this.Redirect(this.LogonResultUrl(Guid.Empty));
      }
      return (ActionResult) this.Redirect(registrationAttemptResponse.RedirectUri);
    }

    [AcceptVerbs(HttpVerbs.Get)]
    public ActionResult RegisterNewResult(string resultId)
    {
      ISSOState ssoState = WebSessionAccessHelper.GetSSOState(this.HttpContext);
      if (ssoState.NewUserRegistrationAttempt != Guid.Empty)
      {
        ssoState.NewUserRegistrationAttempt = Guid.Empty;
        WebSessionAccessHelper.SetSSOState(this.HttpContext, ssoState);
        Guid result = Guid.Empty;
        if (Guid.TryParse(resultId, out result) && result != Guid.Empty)
        {
          try
          {
            EndRegistrationAttemptResponse registrationAttemptResponse = SSOServiceCallHelper.EndNewUserRegistrationAttempt(SSOController.AppConfig, result);
            if (registrationAttemptResponse.Item is RegistrationSuccessResult)
            {
              RegistrationSuccessResult registrationSuccessResult = (RegistrationSuccessResult) registrationAttemptResponse.Item;
              SuccessResult successResult = (SuccessResult) registrationSuccessResult.Item;
              ssoState.Result = (object) successResult;
              WebSessionAccessHelper.SetSSOState(this.HttpContext, ssoState);
              WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, string.Format("Registration successful. Email {0}, activation link: {1}", (object) registrationSuccessResult.EmailAddress, (object) registrationSuccessResult.ActivationLinkUri), ReasonCode.OK);
              PersonAccessInfo accessInfoByEmail = UMClient.UMRepositoryClient.GetAccessInfoByEmail(SSOController.AppConfig.ProductId, SSOController.AppConfig.ApplicationId, successResult.EmailAddress, false);
              if (accessInfoByEmail.PersonInfo.SageIdentityId != successResult.IdentityId)
              {
                UMClient.UMRepositoryClient.AssociateUser(accessInfoByEmail.ProductUserId, successResult.IdentityId);
                UMClient.UMRepositoryClient.ConfirmUser(accessInfoByEmail.ProductUserId);
              }
            }
            else
            {
              RegistrationFailedResult registrationFailedResult = (RegistrationFailedResult) registrationAttemptResponse.Item;
              ssoState.Result = (object) registrationFailedResult;
              WebSessionAccessHelper.SetSSOState(this.HttpContext, ssoState);
              if (registrationFailedResult.Reason != RegistrationFailureReason.RegistrationCancelled)
                WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, string.Format("Registration unsuccessful. Reason: {0}", (object) ((object) registrationFailedResult.Reason).ToString()), ReasonCode.ProtocolViolation);
            }
          }
          catch (Exception ex)
          {
            WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, string.Format("Exception of type {0} raised when calling WebSSOService.EndNewUserRegistrationAttempt(). {1}", (object) ex.GetType().FullName, (object) ex.Message), ReasonCode.ProtocolViolation);
          }
        }
      }
      return (ActionResult) this.Redirect(this.LogonResultUrl(Guid.Empty));
    }

    [AcceptVerbs(HttpVerbs.Get)]
    public ActionResult RegisterExisting()
    {
      StartRegistrationAttemptResponse registrationAttemptResponse;
      try
      {
        registrationAttemptResponse = SSOServiceCallHelper.StartExistingUserRegistrationAttempt(SSOController.AppConfig, string.Format("{0}/{{0}}", (object) UriHelper.ToAbsoluteUri(SSOController.AppConfig, this.HttpContext, this.Url.RouteUrl("RegisterExistingResult", (RouteValueDictionary) null)).AbsoluteUri), this.HttpContext.Session.Timeout);
      }
      catch (Exception ex)
      {
        WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, string.Format("Exception of type {0} raised when calling WebSSOService.StartExistingUserRegistrationAttempt(). {1}", (object) ex.GetType().FullName, (object) ex.Message), ReasonCode.ProtocolViolation);
        return (ActionResult) this.Redirect(this.LogonResultUrl(Guid.Empty));
      }
      ISSOState ssoState = WebSessionAccessHelper.GetSSOState(this.HttpContext);
      ssoState.ExistingUserRegistrationAttempt = registrationAttemptResponse.RegistrationAttemptId;
      WebSessionAccessHelper.SetSSOState(this.HttpContext, ssoState);
      return (ActionResult) this.Redirect(registrationAttemptResponse.RedirectUri);
    }

    [AcceptVerbs(HttpVerbs.Get)]
    public ActionResult RegisterExistingResult(string resultId)
    {
      ISSOState ssoState = WebSessionAccessHelper.GetSSOState(this.HttpContext);
      if (ssoState.ExistingUserRegistrationAttempt != Guid.Empty)
      {
        ssoState.ExistingUserRegistrationAttempt = Guid.Empty;
        WebSessionAccessHelper.SetSSOState(this.HttpContext, ssoState);
        Guid result1 = Guid.Empty;
        if (Guid.TryParse(resultId, out result1) && result1 != Guid.Empty)
        {
          try
          {
            EndRegistrationAttemptResponse registrationAttemptResponse = SSOServiceCallHelper.EndExistingUserRegistrationAttempt(SSOController.AppConfig, result1);
            if (registrationAttemptResponse.Item is RegistrationSuccessResult)
            {
              SuccessResult successResult = (SuccessResult) ((RegistrationSuccessResult) registrationAttemptResponse.Item).Item;
              UMClient.UMRepositoryClient.AssociateUser(ssoState.RegistrationProductUserId, successResult.IdentityId);
              UMClient.UMRepositoryClient.ConfirmUser(ssoState.RegistrationProductUserId);
              ssoState.Result = (object) successResult;
              WebSessionAccessHelper.SetSSOState(this.HttpContext, ssoState);
              WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, "Registration successful.", ReasonCode.OK);
            }
            else
            {
              RegistrationFailedResult registrationFailedResult = (RegistrationFailedResult) registrationAttemptResponse.Item;
              if (registrationFailedResult.Reason == RegistrationFailureReason.AccountAlreadyRegistered)
              {
                bool flag;
                try
                {
                  PersonAccessInfo infoByProductUser = UMClient.UMRepositoryClient.GetAccessInfoByProductUser(SSOController._AppConfig.ApplicationId, ssoState.RegistrationProductUserId, false);
                  if (infoByProductUser.PersonInfo.SageIdentityId != Guid.Empty)
                    UMClient.UMRepositoryClient.AssociateUser(ssoState.RegistrationProductUserId, infoByProductUser.PersonInfo.SageIdentityId);
                  flag = true;
                }
                catch (Exception ex)
                {
                  flag = false;
                }
                if (flag)
                  return (ActionResult) this.RedirectToAction("SignOnInit");
                WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, "User already registered. The Sage ID state and user data for this account do not match. Please contact support.", ReasonCode.AccountAlreadyRegistered);
              }
              if (registrationFailedResult.Reason != RegistrationFailureReason.RegistrationCancelled)
              {
                ReasonCode result2;
                if (!Enum.TryParse<ReasonCode>(((object) registrationFailedResult.Reason).ToString(), out result2))
                  result2 = ReasonCode.ProtocolViolation;
                WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, string.Format("Registration unsuccessful. Reason: {0}", (object) ((object) result2).ToString()), result2);
              }
              else
                WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, "Registration cancelled.", ReasonCode.RegistrationCancelled);
            }
          }
          catch (Exception ex)
          {
            WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, string.Format("Exception of type {0} raised when calling WebSSOService.EndExistingUserRegistrationAttempt(). {1}", (object) ex.GetType().FullName, (object) ex.Message), ReasonCode.ProtocolViolation);
          }
        }
      }
      return (ActionResult) this.Redirect(this.LogonResultUrl(Guid.Empty));
    }

    [AcceptVerbs(HttpVerbs.Get)]
    public ActionResult SignUpInit(string emailReference)
    {
      TraceHelper.TraceLog((Controller) this, "SignUpInit", new object[1]
      {
        (object) emailReference
      });
      UMClient umClient = new UMClient();
      string absoluteUri;
      try
      {
        TraceHelper.TraceLog((Controller) this, "SignUpInit StartUserSignup", new object[0]);
        absoluteUri = umClient.StartUserSignup((Controller) this, emailReference).AbsoluteUri;
      }
      catch (Exception ex)
      {
        TraceHelper.TraceLog((Controller) this, "SignUpInit error", new object[1]
        {
          (object) ex
        });
        WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, string.Format("Exception of type {0} raised when calling WebSSOService.StartExistingUserRegistrationAttempt(). {1}", (object) ex.GetType().FullName, (object) ex.Message), ReasonCode.ProtocolViolation);
        absoluteUri = UriHelper.ToAbsoluteUri(SSOController.AppConfig, this.HttpContext, string.Format(SSOController.AppConfig.LogonResultUrl, (object) Guid.Empty)).AbsoluteUri;
      }
      TraceHelper.TraceLog((Controller) this, "SignUpInit returns", new object[1]
      {
        (object) absoluteUri
      });
      return (ActionResult) this.Redirect(absoluteUri);
    }

    [AcceptVerbs(HttpVerbs.Get)]
    public ActionResult Trace()
    {
      return (ActionResult) this.Content(TraceHelper.TraceLogOutput((Controller) this), "text/plain", Encoding.Default);
    }

    private string LogonResultUrl(Guid result)
    {
      return UriHelper.ToAbsoluteUri(SSOController.AppConfig, this.HttpContext, string.Format(SSOController.AppConfig.LogonResultUrl, (object) result)).AbsoluteUri;
    }

    [AcceptVerbs(HttpVerbs.Get)]
    [Authorize]
    public ActionResult SignOutAll()
    {
      TraceHelper.TraceLog((Controller) this, "SignOutAll", new object[0]);
      Guid guid = Guid.Empty;
      TraceHelper.TraceLog((Controller) this, "SignOutAll HasSession", new object[0]);
      if (SSOSession.HasSession(this.HttpContext))
      {
        TraceHelper.TraceLog((Controller) this, "SignOutAll HasSession=true", new object[0]);
        SSOSession ssoSession = SSOSession.Current(this.HttpContext);
        guid = ssoSession.SSOSessionId;
        TraceHelper.TraceLog((Controller) this, "SignOutAll Session.End", new object[1]
        {
          (object) guid
        });
        ssoSession.End(this.HttpContext);
      }
      TraceHelper.TraceLog((Controller) this, "SignOutAll Session.Abandon", new object[0]);
      try
      {
        this.Response.AppendHeader("diag", TraceHelper.TraceLogOutput((Controller) this));
      }
      catch
      {
      }
      this.Session.Abandon();
      if (guid != Guid.Empty)
      {
        try
        {
          using (WebSSOServiceSoapClient serviceSoapClient = new WebSSOServiceSoapClient(SSOController.AppConfig.SageIdClientConfig))
          {
            serviceSoapClient.Open();
            TraceHelper.TraceLog((Controller) this, "SignOutAll SessionSignOffRequest", new object[1]
            {
              (object) guid
            });
            SessionSignOffRequest request = new SessionSignOffRequest()
            {
              SessionId = guid
            };
            TraceHelper.TraceLog((Controller) this, "SignOutAll result", new object[1]
            {
              (object) serviceSoapClient.SessionSignOff(request)
            });
          }
        }
        catch (Exception ex)
        {
          TraceHelper.TraceLog((Controller) this, "SignOutAll error", new object[1]
          {
            (object) ex
          });
          WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, string.Format("Exception of type {0} raised when calling WebSSOService.SessionSignOff(). {1}", (object) ex.GetType().FullName, (object) ex.Message), ReasonCode.ProtocolViolation);
        }
      }
      return (ActionResult) this.RedirectToAction("SignIn", "CESageIdHome", (object) new
      {
        sessionEnded = "true"
      });
    }

    [Authorize]
    [AcceptVerbs(HttpVerbs.Get)]
    public ActionResult SignOut()
    {
      TraceHelper.TraceLog((Controller) this, "SignOut", new object[0]);
      Guid guid = Guid.Empty;
      TraceHelper.TraceLog((Controller) this, "SignOut HasSession", new object[0]);
      if (SSOSession.HasSession(this.HttpContext))
      {
        TraceHelper.TraceLog((Controller) this, "SignOut HasSession = true", new object[0]);
        SSOSession ssoSession = SSOSession.Current(this.HttpContext);
        TraceHelper.TraceLog((Controller) this, "SignOut SSOSession", new object[1]
        {
          (object) ssoSession
        });
        guid = ssoSession.SSOSessionId;
        TraceHelper.TraceLog((Controller) this, "SignOut Session.End", new object[0]);
        ssoSession.End(this.HttpContext);
      }
      TraceHelper.TraceLog((Controller) this, "SignOut Session.Abandon", new object[0]);
      try
      {
        this.Response.AppendHeader("diag", TraceHelper.TraceLogOutput((Controller) this));
      }
      catch
      {
      }
      this.Session.Abandon();
      if (guid != Guid.Empty)
      {
        try
        {
          TraceHelper.TraceLog((Controller) this, "SignOut WebSSOServiceSoapClient", new object[1]
          {
            (object) SSOController.AppConfig.SageIdClientConfig
          });
          using (WebSSOServiceSoapClient serviceSoapClient = new WebSSOServiceSoapClient(SSOController.AppConfig.SageIdClientConfig))
          {
            serviceSoapClient.Open();
            SessionRemoveParticipantRequest request = new SessionRemoveParticipantRequest()
            {
              SessionId = guid
            };
            TraceHelper.TraceLog((Controller) this, "SignOut SessionRemoveParticipant", new object[1]
            {
              (object) guid
            });
            TraceHelper.TraceLog((Controller) this, "SignOut SessionRemoveParticipant returns", new object[1]
            {
              (object) serviceSoapClient.SessionRemoveParticipant(request)
            });
          }
        }
        catch (Exception ex)
        {
          TraceHelper.TraceLog((Controller) this, "SignOut error", new object[1]
          {
            (object) ex
          });
          WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, string.Format("Exception of type {0} raised when calling WebSSOService.SessionRemoveParticipant(). {1}", (object) ex.GetType().FullName, (object) ex.Message), ReasonCode.ProtocolViolation);
        }
      }
      TraceHelper.TraceLog((Controller) this, "SignOut returns", new object[1]
      {
        (object) "Action SignIn CESageIdHome"
      });
      return (ActionResult) this.RedirectToAction("SignIn", "CESageIdHome", (object) new
      {
        sessionEnded = "true"
      });
    }

    [AcceptVerbs(HttpVerbs.Get)]
    public ActionResult SignOnInit()
    {
      TraceHelper.TraceLog((Controller) this, "SignOnInit", new object[0]);
      string absoluteUri = new UMClient().StartSignOn((Controller) this).AbsoluteUri;
      TraceHelper.TraceLog((Controller) this, "SignOnInit", new object[1]
      {
        (object) absoluteUri
      });
      return (ActionResult) this.Redirect(absoluteUri);
    }

    [AcceptVerbs(HttpVerbs.Get)]
    public ActionResult SignOnSuccessful(string resultId)
    {
      TraceHelper.TraceLog((Controller) this, "SignOnSuccessful", new object[0]);
      Guid result = Guid.Empty;
      Guid.TryParse(resultId, out result);
      string url = this.LogonResultUrl(result);
      TraceHelper.TraceLog((Controller) this, "SignOnSuccessful", new object[1]
      {
        (object) url
      });
      return (ActionResult) this.Redirect(url);
    }

    [AcceptVerbs(HttpVerbs.Get)]
    public ActionResult SignOnFailed(string resultId)
    {
      TraceHelper.TraceLog((Controller) this, "SignOnFailed", new object[1]
      {
        (object) resultId
      });
      ISSOState ssoState = WebSessionAccessHelper.GetSSOState(this.HttpContext);
      TraceHelper.TraceLog((Controller) this, "SignOnFailed state", new object[1]
      {
        (object) ssoState
      });
      if (ssoState.SignOnAttempt != Guid.Empty)
      {
        ssoState.SignOnAttempt = Guid.Empty;
        WebSessionAccessHelper.SetSSOState(this.HttpContext, ssoState);
        Guid result1 = Guid.Empty;
        if (Guid.TryParse(resultId, out result1))
        {
          try
          {
            TraceHelper.TraceLog((Controller) this, "SignOnFailed WebSSOServiceSoapClient", new object[0]);
            using (WebSSOServiceSoapClient serviceSoapClient = new WebSSOServiceSoapClient(SSOController.AppConfig.SageIdClientConfig))
            {
              EndSignOnAttemptResponse onAttemptResponse = serviceSoapClient.EndSignOnAttempt(new EndSignOnAttemptRequest()
              {
                ResultId = result1
              });
              TraceHelper.TraceLog((Controller) this, "SignOnFailed WebSSOServiceSoapClient.EndSignOnAttempt", new object[1]
              {
                (object) onAttemptResponse
              });
              FailedResult result2 = (FailedResult) onAttemptResponse.Item;
              if (result2.Reason == FailureReason.AccountPasswordReset)
              {
                Uri uri = new Uri(UMClient.UMRepositoryClient.GetUserAdminAppUrl());
                return (ActionResult) this.Redirect(new UriBuilder(uri.Scheme, uri.Host, uri.Port, "/home/passwordresetrequest").Uri.AbsoluteUri);
              }
              else
              {
                string message = SSOController.BuildFailureMessage(result2);
                TraceHelper.TraceLog((Controller) this, "SignOnFailed BuildFailureMessage", new object[1]
                {
                  (object) message
                });
                ReasonCode result3;
                if (!Enum.TryParse<ReasonCode>(((object) result2.Reason).ToString(), out result3))
                  result3 = ReasonCode.ProtocolViolation;
                WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, message, result3);
              }
            }
          }
          catch (Exception ex)
          {
            TraceHelper.TraceLog((Controller) this, "SignOnFailed error", new object[1]
            {
              (object) ex
            });
            WebSessionAccessHelper.SetSSOMessageResult(this.HttpContext, string.Format("Exception of type {0} raised when calling WebSSOService.EndSignOnAttempt(). {1}", (object) ex.GetType().FullName, (object) ex.Message), ReasonCode.ProtocolViolation);
          }
        }
      }
      return (ActionResult) this.Redirect(this.LogonResultUrl(Guid.Empty));
    }

    private static string BuildFailureMessage(FailedResult result)
    {
      string str = string.Empty;
      switch (result.Reason)
      {
        case FailureReason.ProtocolViolation:
        case FailureReason.UnknownAccount:
        case FailureReason.SignOnAttemptNotFound:
          str = string.Format("An error occured during sign-in. ({0})", (object) ((object) result.Reason).ToString());
          break;
        case FailureReason.AccountNotActivated:
          str = string.Format("Account is not activated. ({0}) {1}{2}{3}", (object) ((object) result.Reason).ToString(), result.IdentityIdSpecified ? (object) (" IdentityId=" + result.IdentityId.ToString()) : (object) string.Empty, !string.IsNullOrEmpty(result.DisplayName) ? (object) (", DisplayName=" + result.DisplayName) : (object) string.Empty, !string.IsNullOrEmpty(result.EmailAddress) ? (object) (", EmailAddress=" + result.EmailAddress) : (object) string.Empty);
          break;
        case FailureReason.AccountSoftLocked:
          str = string.Format("Account has been temporarily locked. ({0}) {1}{2}{3}", (object) ((object) result.Reason).ToString(), result.IdentityIdSpecified ? (object) (" IdentityId=" + result.IdentityId.ToString()) : (object) string.Empty, !string.IsNullOrEmpty(result.DisplayName) ? (object) (", DisplayName=" + result.DisplayName) : (object) string.Empty, !string.IsNullOrEmpty(result.EmailAddress) ? (object) (", EmailAddress=" + result.EmailAddress) : (object) string.Empty);
          break;
        case FailureReason.AccountHardLocked:
          str = string.Format("Account has been hard locked and must be unlocked by an administrator. ({0}) {1}{2}{3}", (object) ((object) result.Reason).ToString(), result.IdentityIdSpecified ? (object) (" IdentityId=" + result.IdentityId.ToString()) : (object) string.Empty, !string.IsNullOrEmpty(result.DisplayName) ? (object) (", DisplayName=" + result.DisplayName) : (object) string.Empty, !string.IsNullOrEmpty(result.EmailAddress) ? (object) (", EmailAddress=" + result.EmailAddress) : (object) string.Empty);
          break;
        case FailureReason.AccountExpired:
          str = string.Format("Account has expired. ({0}) {1}{2}{3}", (object) ((object) result.Reason).ToString(), result.IdentityIdSpecified ? (object) (" IdentityId=" + result.IdentityId.ToString()) : (object) string.Empty, !string.IsNullOrEmpty(result.DisplayName) ? (object) (", DisplayName=" + result.DisplayName) : (object) string.Empty, !string.IsNullOrEmpty(result.EmailAddress) ? (object) (", EmailAddress=" + result.EmailAddress) : (object) string.Empty);
          break;
        case FailureReason.AccountNotRegistered:
          str = string.Format("Account exists but is not registered for this application. ({0}) {1}{2}{3}", (object) ((object) result.Reason).ToString(), result.IdentityIdSpecified ? (object) (" IdentityId=" + result.IdentityId.ToString()) : (object) string.Empty, !string.IsNullOrEmpty(result.DisplayName) ? (object) (", DisplayName=" + result.DisplayName) : (object) string.Empty, !string.IsNullOrEmpty(result.EmailAddress) ? (object) (", EmailAddress=" + result.EmailAddress) : (object) string.Empty);
          break;
        case FailureReason.SessionExpired:
          str = string.Format("The sign-in page expired. ({0})", (object) ((object) result.Reason).ToString());
          break;
        case FailureReason.SignOnCancelled:
          str = "Sign-on cancelled.";
          break;
        case FailureReason.AccountPasswordReset:
          str = string.Format("Password recovery successful. An activation email was sent which includes the following activation link: {0}. ({1})", (object) result.ActivationLinkUri, (object) ((object) result.Reason).ToString());
          break;
        case FailureReason.ValidationFailed:
          str = string.Format("Password recovery unsuccessful. ({0})", (object) ((object) result.Reason).ToString());
          break;
        case FailureReason.AccountBlocked:
          str = string.Format("Account has been blocked for this application. ({0}) {1}{2}{3}", (object) ((object) result.Reason).ToString(), result.IdentityIdSpecified ? (object) (" IdentityId=" + result.IdentityId.ToString()) : (object) string.Empty, !string.IsNullOrEmpty(result.DisplayName) ? (object) (", DisplayName=" + result.DisplayName) : (object) string.Empty, !string.IsNullOrEmpty(result.EmailAddress) ? (object) (", EmailAddress=" + result.EmailAddress) : (object) string.Empty);
          break;
      }
      return str;
    }
  }
}
