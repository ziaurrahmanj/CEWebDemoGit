// Type: SageNA.CE.UM.Client.SSOServiceCallHelper
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using SageNA.CE.UMClientInterface;
using SageSSO.ServiceReferences;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;

namespace SageNA.CE.UM.Client
{
  internal static class SSOServiceCallHelper
  {
    private static bool _CertTrustOverrideInitialized = false;

    static SSOServiceCallHelper()
    {
    }

    internal static StartSignOnAttemptResponse StartSignOnAttempt(AppConfig appConfig, string successUri, string failureUri, bool cancelAllowed, int sessionLengthMinutes, string templateName)
    {
      StartSignOnAttemptResponse onAttemptResponse;
      using (WebSSOServiceSoapClient ssoServiceClient = SSOServiceCallHelper.CreateSSOServiceClient(appConfig))
      {
        ssoServiceClient.Open();
        StartSignOnAttemptRequest request = new StartSignOnAttemptRequest()
        {
          SuccessUri = successUri,
          FailureUri = failureUri,
          CancelAllowed = cancelAllowed,
          SessionLengthMinutes = sessionLengthMinutes,
          SessionLengthMinutesSpecified = sessionLengthMinutes != 0,
          TemplateName = templateName
        };
        onAttemptResponse = ssoServiceClient.StartSignOnAttempt(request);
        ssoServiceClient.Close();
      }
      return onAttemptResponse;
    }

    internal static EndSignOnAttemptResponse EndSignOnAttempt(AppConfig appConfig, Guid resultIdGuid)
    {
      EndSignOnAttemptResponse onAttemptResponse;
      using (WebSSOServiceSoapClient ssoServiceClient = SSOServiceCallHelper.CreateSSOServiceClient(appConfig))
      {
        ssoServiceClient.Open();
        EndSignOnAttemptRequest request = new EndSignOnAttemptRequest()
        {
          ResultId = resultIdGuid
        };
        onAttemptResponse = ssoServiceClient.EndSignOnAttempt(request);
        ssoServiceClient.Close();
      }
      return onAttemptResponse;
    }

    internal static StartRegistrationAttemptResponse StartNewUserRegistrationAttempt(AppConfig appConfig, Uri resultUri, string email, string displayName, int timeOutMinutes, bool activateAfterSuccess)
    {
      StartRegistrationAttemptResponse registrationAttemptResponse;
      using (WebSSOServiceSoapClient ssoServiceClient = SSOServiceCallHelper.CreateSSOServiceClient(appConfig))
      {
        ssoServiceClient.Open();
        StartNewUserRegistrationAttemptRequest request = new StartNewUserRegistrationAttemptRequest()
        {
          SuccessUri = resultUri.ToString(),
          FailureUri = resultUri.ToString(),
          CancelAllowed = true,
          SignOnAfterSuccess = true,
          EmailAddress = email,
          DisplayName = displayName,
          SessionLengthMinutes = timeOutMinutes,
          SessionLengthMinutesSpecified = true,
          ActivateAfterSuccess = activateAfterSuccess
        };
        registrationAttemptResponse = ssoServiceClient.StartNewUserRegistrationAttempt(request);
        ssoServiceClient.Close();
      }
      return registrationAttemptResponse;
    }

    internal static StartRegistrationAttemptResponse StartExistingUserRegistrationAttempt(AppConfig appConfig, string resultUri, int timeOutMinutes)
    {
      StartRegistrationAttemptResponse registrationAttemptResponse;
      using (WebSSOServiceSoapClient ssoServiceClient = SSOServiceCallHelper.CreateSSOServiceClient(appConfig))
      {
        ssoServiceClient.Open();
        StartExistingUserRegistrationAttemptRequest request = new StartExistingUserRegistrationAttemptRequest()
        {
          SuccessUri = resultUri,
          FailureUri = resultUri,
          CancelAllowed = true,
          SessionLengthMinutes = timeOutMinutes,
          SessionLengthMinutesSpecified = true
        };
        registrationAttemptResponse = ssoServiceClient.StartExistingUserRegistrationAttempt(request);
        ssoServiceClient.Close();
      }
      return registrationAttemptResponse;
    }

    internal static EndRegistrationAttemptResponse EndNewUserRegistrationAttempt(AppConfig appConfig, Guid resultIdGuid)
    {
      EndRegistrationAttemptResponse registrationAttemptResponse;
      using (WebSSOServiceSoapClient ssoServiceClient = SSOServiceCallHelper.CreateSSOServiceClient(appConfig))
      {
        ssoServiceClient.Open();
        EndRegistrationAttemptRequest request = new EndRegistrationAttemptRequest()
        {
          ResultId = resultIdGuid
        };
        registrationAttemptResponse = ssoServiceClient.EndNewUserRegistrationAttempt(request);
        ssoServiceClient.Close();
      }
      return registrationAttemptResponse;
    }

    internal static EndRegistrationAttemptResponse EndExistingUserRegistrationAttempt(AppConfig appConfig, Guid resultIdGuid)
    {
      EndRegistrationAttemptResponse registrationAttemptResponse;
      using (WebSSOServiceSoapClient ssoServiceClient = SSOServiceCallHelper.CreateSSOServiceClient(appConfig))
      {
        ssoServiceClient.Open();
        EndRegistrationAttemptRequest request = new EndRegistrationAttemptRequest()
        {
          ResultId = resultIdGuid
        };
        registrationAttemptResponse = ssoServiceClient.EndExistingUserRegistrationAttempt(request);
        ssoServiceClient.Close();
      }
      return registrationAttemptResponse;
    }

    internal static SessionExtendResponse SessionExtend(AppConfig appConfig, Guid ssoSessionId, int timeoutMinutes)
    {
      SessionExtendResponse sessionExtendResponse;
      using (WebSSOServiceSoapClient ssoServiceClient = SSOServiceCallHelper.CreateSSOServiceClient(appConfig))
      {
        ssoServiceClient.Open();
        SessionExtendRequest request = new SessionExtendRequest()
        {
          SessionId = ssoSessionId,
          SessionExpiry = DateTime.UtcNow + TimeSpan.FromMinutes((double) timeoutMinutes),
          SessionExpirySpecified = true
        };
        sessionExtendResponse = ssoServiceClient.SessionExtend(request);
        ssoServiceClient.Close();
      }
      return sessionExtendResponse;
    }

    internal static SessionRemoveParticipantResponse SessionRemoveParticipant(AppConfig appConfig, Guid ssoSessionId)
    {
      SessionRemoveParticipantResponse participantResponse;
      using (WebSSOServiceSoapClient ssoServiceClient = SSOServiceCallHelper.CreateSSOServiceClient(appConfig))
      {
        ssoServiceClient.Open();
        SessionRemoveParticipantRequest request = new SessionRemoveParticipantRequest()
        {
          SessionId = ssoSessionId
        };
        participantResponse = ssoServiceClient.SessionRemoveParticipant(request);
        ssoServiceClient.Close();
      }
      return participantResponse;
    }

    internal static ListUserIdentitiesResponse ListUserIdentities(AppConfig appConfig, string email)
    {
      ListUserIdentitiesResponse identitiesResponse;
      using (IdentityManagementServiceSoapClient managementServiceClient = SSOServiceCallHelper.CreateIdentityManagementServiceClient(appConfig))
      {
        managementServiceClient.Open();
        ListUserIdentitiesRequest request = new ListUserIdentitiesRequest()
        {
          Offset = 0,
          Count = 1,
          Order = ListSortOrder.Ascending,
          FilterField = "EmailAddress",
          Filter = email
        };
        identitiesResponse = managementServiceClient.ListUserIdentities(request);
        managementServiceClient.Close();
      }
      return identitiesResponse;
    }

    internal static void MarkActivated(AppConfig appConfig, Guid identity)
    {
      using (UserAccountManagementServiceSoapClient managementServiceClient = SSOServiceCallHelper.CreateAccountManagementServiceClient(appConfig))
      {
        managementServiceClient.Open();
        MarkActivatedRequest request = new MarkActivatedRequest()
        {
          IdentityId = identity
        };
        managementServiceClient.MarkActivated(request);
        managementServiceClient.Close();
      }
    }

    internal static void MarkActivatedUsingUrl(AppConfig appConfig, string activationUrl)
    {
      HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(activationUrl);
      httpWebRequest.Method = "GET";
      httpWebRequest.AllowAutoRedirect = false;
      try
      {
        string responseHeader;
        using (HttpWebResponse httpWebResponse = (HttpWebResponse) httpWebRequest.GetResponse())
        {
          HttpStatusCode statusCode = httpWebResponse.StatusCode;
          if (statusCode != HttpStatusCode.Found)
            throw new Exception(string.Format("Invalid request return status code - {0}.", (object) statusCode));
          responseHeader = httpWebResponse.GetResponseHeader("Location");
        }
        Guid result;
        if (!Guid.TryParse(responseHeader.Substring(responseHeader.LastIndexOf('/') + 1), out result))
          throw new Exception("Activation return value not a GUID.");
        Dictionary<string, string> dictionary;
        using (WebSSOServiceSoapClient ssoServiceClient = SSOServiceCallHelper.CreateSSOServiceClient(appConfig))
        {
          ssoServiceClient.Open();
          dictionary = SSOServiceCallHelper.ContextToDict(ssoServiceClient.ActivationLinkContext(new ActivationLinkContextRequest()
          {
            ActivationId = result
          }));
          ssoServiceClient.Close();
        }
        if (dictionary["Result"] != "Activated")
          throw new Exception(string.Format("Account was not successfully activated for user identity {0}.", (object) dictionary["IdentityId"]));
      }
      catch (Exception ex)
      {
        throw new Exception("Account was not successfully activated.", ex);
      }
    }

    internal static ActivationLinkContextResponse ActivationLinkContext(AppConfig appConfig, Guid activationId)
    {
      ActivationLinkContextResponse linkContextResponse;
      using (WebSSOServiceSoapClient ssoServiceClient = SSOServiceCallHelper.CreateSSOServiceClient(appConfig))
      {
        ssoServiceClient.Open();
        ActivationLinkContextRequest request = new ActivationLinkContextRequest()
        {
          ActivationId = activationId
        };
        linkContextResponse = ssoServiceClient.ActivationLinkContext(request);
        ssoServiceClient.Close();
      }
      return linkContextResponse;
    }

    public static Dictionary<string, string> ContextToDict(ActivationLinkContextResponse response)
    {
      Dictionary<string, string> dictionary = new Dictionary<string, string>();
      foreach (ActivationLinkContextItem activationLinkContextItem in response.Items)
        dictionary.Add(activationLinkContextItem.Name, activationLinkContextItem.Value);
      return dictionary;
    }

    private static WebSSOServiceSoapClient CreateSSOServiceClient(AppConfig appConfig)
    {
      SSOServiceCallHelper.InitServicePointManager();
      return new WebSSOServiceSoapClient(appConfig.SageIdClientConfig);
    }

    private static IdentityManagementServiceSoapClient CreateIdentityManagementServiceClient(AppConfig appConfig)
    {
      SSOServiceCallHelper.InitServicePointManager();
      return new IdentityManagementServiceSoapClient(appConfig.SageIdClientConfigIM);
    }

    private static UserAccountManagementServiceSoapClient CreateAccountManagementServiceClient(AppConfig appConfig)
    {
      SSOServiceCallHelper.InitServicePointManager();
      return new UserAccountManagementServiceSoapClient(appConfig.SageIdClientConfigAM);
    }

    public static void InitServicePointManager()
    {
      if (SSOServiceCallHelper._CertTrustOverrideInitialized)
        return;
      SSOServiceCallHelper._CertTrustOverrideInitialized = true;
      try
      {
        ServicePointManager.ServerCertificateValidationCallback += (RemoteCertificateValidationCallback) ((sender, certificate, chain, policyErrors) => true);
      }
      catch
      {
      }
    }
  }
}
