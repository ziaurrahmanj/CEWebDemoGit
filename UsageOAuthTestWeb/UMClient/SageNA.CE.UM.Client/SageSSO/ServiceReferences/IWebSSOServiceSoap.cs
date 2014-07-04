// Type: SageSSO.ServiceReferences.IWebSSOServiceSoap
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System.CodeDom.Compiler;
using System.ServiceModel;

namespace SageSSO.ServiceReferences
{
  [ServiceContract(ConfigurationName = "SageSSO.ServiceReferences.IWebSSOServiceSoap", Namespace = "http://sso.sage.com", SessionMode = SessionMode.NotAllowed)]
  [GeneratedCode("System.ServiceModel", "3.0.0.0")]
  public interface IWebSSOServiceSoap
  {
    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/StartSignOnAttempt", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/StartSignOnAttemptResponse")]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    [ServiceKnownType(typeof (Updateable))]
    StartSignOnAttemptResponse StartSignOnAttempt(StartSignOnAttemptRequest request);

    [XmlSerializerFormat]
    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/EndSignOnAttempt", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/EndSignOnAttemptResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    EndSignOnAttemptResponse EndSignOnAttempt(EndSignOnAttemptRequest request);

    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/StartNewUserRegistrationAttempt", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/StartNewUserRegistrationAttemptResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    StartRegistrationAttemptResponse StartNewUserRegistrationAttempt(StartNewUserRegistrationAttemptRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/EndNewUserRegistrationAttempt", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/EndNewUserRegistrationAttemptResponse")]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    EndRegistrationAttemptResponse EndNewUserRegistrationAttempt(EndRegistrationAttemptRequest request);

    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/StartExistingUserRegistrationAttempt", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/StartExistingUserRegistrationAttemptResponse")]
    [ServiceKnownType(typeof (Principal))]
    StartRegistrationAttemptResponse StartExistingUserRegistrationAttempt(StartExistingUserRegistrationAttemptRequest request);

    [XmlSerializerFormat]
    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/EndExistingUserRegistrationAttempt", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/EndExistingUserRegistrationAttemptResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    EndRegistrationAttemptResponse EndExistingUserRegistrationAttempt(EndRegistrationAttemptRequest request);

    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/StartPasswordRecoveryAttempt", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/StartPasswordRecoveryAttemptResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    StartPasswordRecoveryAttemptResponse StartPasswordRecoveryAttempt(StartPasswordRecoveryAttemptRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/EndPasswordRecoveryAttempt", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/EndPasswordRecoveryAttemptResponse")]
    [XmlSerializerFormat]
    EndPasswordRecoveryAttemptResponse EndPasswordRecoveryAttempt(EndPasswordRecoveryAttemptRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/StartPasswordChangeAttempt", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/StartPasswordChangeAttemptResponse")]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    StartPasswordChangeAttemptResponse StartPasswordChangeAttempt(StartPasswordChangeAttemptRequest request);

    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/EndPasswordChangeAttempt", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/EndPasswordChangeAttemptResponse")]
    [ServiceKnownType(typeof (Principal))]
    EndPasswordChangeAttemptResponse EndPasswordChangeAttempt(EndPasswordChangeAttemptRequest request);

    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/StartManageAuthorisationAttempt", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/StartManageAuthorisationAttemptResponse")]
    StartManageAuthorisationAttemptResponse StartManageAuthorisationAttempt(StartManageAuthorisationAttemptRequest request);

    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/EndManageAuthorisationAttempt", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/EndManageAuthorisationAttemptResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    EndManageAuthorisationAttemptResponse EndManageAuthorisationAttempt(EndManageAuthorisationAttemptRequest request);

    [ServiceKnownType(typeof (Principal))]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/SessionRemoveParticipant", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/SessionRemoveParticipantResponse")]
    SessionRemoveParticipantResponse SessionRemoveParticipant(SessionRemoveParticipantRequest request);

    [ServiceKnownType(typeof (Principal))]
    [XmlSerializerFormat]
    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/SessionSignOff", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/SessionSignOffResponse")]
    [ServiceKnownType(typeof (Updateable))]
    SessionSignOffResponse SessionSignOff(SessionSignOffRequest request);

    [ServiceKnownType(typeof (Principal))]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/SessionExtend", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/SessionExtendResponse")]
    SessionExtendResponse SessionExtend(SessionExtendRequest request);

    [ServiceKnownType(typeof (Principal))]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    [OperationContract(Action = "http://sso.sage.com/IWebSSOServiceSoap/ActivationLinkContext", ReplyAction = "http://sso.sage.com/IWebSSOServiceSoap/ActivationLinkContextResponse")]
    ActivationLinkContextResponse ActivationLinkContext(ActivationLinkContextRequest request);
  }
}
