// Type: SageSSO.ServiceReferences.WebSSOServiceSoapClient
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace SageSSO.ServiceReferences
{
  [GeneratedCode("System.ServiceModel", "3.0.0.0")]
  [DebuggerStepThrough]
  public class WebSSOServiceSoapClient : ClientBase<IWebSSOServiceSoap>, IWebSSOServiceSoap
  {
    public WebSSOServiceSoapClient()
    {
    }

    public WebSSOServiceSoapClient(string endpointConfigurationName)
      : base(endpointConfigurationName)
    {
    }

    public WebSSOServiceSoapClient(string endpointConfigurationName, string remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public WebSSOServiceSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public WebSSOServiceSoapClient(Binding binding, EndpointAddress remoteAddress)
      : base(binding, remoteAddress)
    {
    }

    public StartSignOnAttemptResponse StartSignOnAttempt(StartSignOnAttemptRequest request)
    {
      return this.Channel.StartSignOnAttempt(request);
    }

    public EndSignOnAttemptResponse EndSignOnAttempt(EndSignOnAttemptRequest request)
    {
      return this.Channel.EndSignOnAttempt(request);
    }

    public StartRegistrationAttemptResponse StartNewUserRegistrationAttempt(StartNewUserRegistrationAttemptRequest request)
    {
      return this.Channel.StartNewUserRegistrationAttempt(request);
    }

    public EndRegistrationAttemptResponse EndNewUserRegistrationAttempt(EndRegistrationAttemptRequest request)
    {
      return this.Channel.EndNewUserRegistrationAttempt(request);
    }

    public StartRegistrationAttemptResponse StartExistingUserRegistrationAttempt(StartExistingUserRegistrationAttemptRequest request)
    {
      return this.Channel.StartExistingUserRegistrationAttempt(request);
    }

    public EndRegistrationAttemptResponse EndExistingUserRegistrationAttempt(EndRegistrationAttemptRequest request)
    {
      return this.Channel.EndExistingUserRegistrationAttempt(request);
    }

    public StartPasswordRecoveryAttemptResponse StartPasswordRecoveryAttempt(StartPasswordRecoveryAttemptRequest request)
    {
      return this.Channel.StartPasswordRecoveryAttempt(request);
    }

    public EndPasswordRecoveryAttemptResponse EndPasswordRecoveryAttempt(EndPasswordRecoveryAttemptRequest request)
    {
      return this.Channel.EndPasswordRecoveryAttempt(request);
    }

    public StartPasswordChangeAttemptResponse StartPasswordChangeAttempt(StartPasswordChangeAttemptRequest request)
    {
      return this.Channel.StartPasswordChangeAttempt(request);
    }

    public EndPasswordChangeAttemptResponse EndPasswordChangeAttempt(EndPasswordChangeAttemptRequest request)
    {
      return this.Channel.EndPasswordChangeAttempt(request);
    }

    public StartManageAuthorisationAttemptResponse StartManageAuthorisationAttempt(StartManageAuthorisationAttemptRequest request)
    {
      return this.Channel.StartManageAuthorisationAttempt(request);
    }

    public EndManageAuthorisationAttemptResponse EndManageAuthorisationAttempt(EndManageAuthorisationAttemptRequest request)
    {
      return this.Channel.EndManageAuthorisationAttempt(request);
    }

    public SessionRemoveParticipantResponse SessionRemoveParticipant(SessionRemoveParticipantRequest request)
    {
      return this.Channel.SessionRemoveParticipant(request);
    }

    public SessionSignOffResponse SessionSignOff(SessionSignOffRequest request)
    {
      return this.Channel.SessionSignOff(request);
    }

    public SessionExtendResponse SessionExtend(SessionExtendRequest request)
    {
      return this.Channel.SessionExtend(request);
    }

    public ActivationLinkContextResponse ActivationLinkContext(ActivationLinkContextRequest request)
    {
      return this.Channel.ActivationLinkContext(request);
    }
  }
}
