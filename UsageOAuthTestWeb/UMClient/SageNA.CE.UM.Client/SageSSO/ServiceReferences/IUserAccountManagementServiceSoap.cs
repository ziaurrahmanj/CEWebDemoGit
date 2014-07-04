// Type: SageSSO.ServiceReferences.IUserAccountManagementServiceSoap
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System.CodeDom.Compiler;
using System.ServiceModel;

namespace SageSSO.ServiceReferences
{
  [ServiceContract(ConfigurationName = "SageSSO.ServiceReferences.IUserAccountManagementServiceSoap", Namespace = "http://sso.sage.com")]
  [GeneratedCode("System.ServiceModel", "3.0.0.0")]
  public interface IUserAccountManagementServiceSoap
  {
    [XmlSerializerFormat]
    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/GetSummary", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/GetSummaryResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    GetSummaryResponse GetSummary(GetSummaryRequest request);

    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/GetEffectiveState", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/GetEffectiveStateResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    GetEffectiveStateResponse GetEffectiveState(GetEffectiveStateRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/ApplyHardLock", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/ApplyHardLockResponse")]
    [XmlSerializerFormat]
    void ApplyHardLock(ApplyHardLockRequest request);

    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/RemoveLock", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/RemoveLockResponse")]
    [ServiceKnownType(typeof (Principal))]
    void RemoveLock(RemoveLockRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/ApplySignOnBlock", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/ApplySignOnBlockResponse")]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    void ApplySignOnBlock(ApplySignOnBlockRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/RemoveSignOnBlock", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/RemoveSignOnBlockResponse")]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    void RemoveSignOnBlock(RemoveSignOnBlockRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/GetSignOnBlockStatus", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/GetSignOnBlockStatusResponse")]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    GetSignOnBlockStatusResponse GetSignOnBlockStatus(GetSignOnBlockStatusRequest request);

    [XmlSerializerFormat]
    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/MarkActivated", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/MarkActivatedResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    void MarkActivated(MarkActivatedRequest request);

    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/GetActivationStatus", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/GetActivationStatusResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    GetActivationStatusResponse GetActivationStatus(GetActivationStatusRequest request);

    [ServiceKnownType(typeof (Principal))]
    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/GetGracePeriodStatus", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/GetGracePeriodStatusResponse")]
    [XmlSerializerFormat]
    GetGracePeriodStatusResponse GetGracePeriodStatus(GetGracePeriodStatusRequest request);

    [XmlSerializerFormat]
    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/ResendActivationEmail", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/ResendActivationEmailResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    void ResendActivationEmail(ResendActivationEmailRequest request);

    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/RegisterForWebApplication", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/RegisterForWebApplicationResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    void RegisterForWebApplication(RegisterForWebApplicationRequest request);

    [ServiceKnownType(typeof (Principal))]
    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/UnregisterFromWebApplication", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/UnregisterFromWebApplicationResponse")]
    [XmlSerializerFormat]
    void UnregisterFromWebApplication(UnregisterFromWebApplicationRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/GetRegisteredWebApplications", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/GetRegisteredWebApplicationsResponse")]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    GetRegisteredWebApplicationsResponse GetRegisteredWebApplications(GetRegisteredWebApplicationsRequest request);

    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/ApplyWebApplicationAutoSignOn", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/ApplyWebApplicationAutoSignOnResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    void ApplyWebApplicationAutoSignOn(ApplyWebApplicationAutoSignOnRequest request);

    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/RemoveWebApplicationAutoSignOn", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/RemoveWebApplicationAutoSignOnResponse")]
    [ServiceKnownType(typeof (Principal))]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    void RemoveWebApplicationAutoSignOn(RemoveWebApplicationAutoSignOnRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/GetWebApplicationAutoSignOnStatus", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/GetWebApplicationAutoSignOnStatusResponse")]
    [XmlSerializerFormat]
    GetWebApplicationAutoSignOnStatusResponse GetWebApplicationAutoSignOnStatus(GetWebApplicationAutoSignOnStatusRequest request);

    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/ListRegisteredUserIdentities", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/ListRegisteredUserIdentitiesResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    [XmlSerializerFormat]
    ListRegisteredUserIdentitiesResponse ListRegisteredUserIdentities(ListRegisteredUserIdentitiesRequest request);

    [ServiceKnownType(typeof (Principal))]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/UpdatePasswordWithActivation", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/UpdatePasswordWithActivationResponse")]
    void UpdatePasswordWithActivation(UpdatePasswordWithActivationRequest request);

    [ServiceKnownType(typeof (Principal))]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    [OperationContract(Action = "http://sso.sage.com/IUserAccountManagementServiceSoap/MarkForcePasswordChangeOnNextSignOn", ReplyAction = "http://sso.sage.com/IUserAccountManagementServiceSoap/MarkForcePasswordChangeOnNextSignOnResponse")]
    void MarkForcePasswordChangeOnNextSignOn(MarkForcePasswordChangeOnNextSignOnRequest request);
  }
}
