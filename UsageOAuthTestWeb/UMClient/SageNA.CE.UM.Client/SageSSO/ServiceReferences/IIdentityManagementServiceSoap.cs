// Type: SageSSO.ServiceReferences.IIdentityManagementServiceSoap
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System.CodeDom.Compiler;
using System.ServiceModel;

namespace SageSSO.ServiceReferences
{
  [ServiceContract(ConfigurationName = "SageSSO.ServiceReferences.IIdentityManagementServiceSoap", Namespace = "http://sso.sage.com", SessionMode = SessionMode.NotAllowed)]
  [GeneratedCode("System.ServiceModel", "3.0.0.0")]
  public interface IIdentityManagementServiceSoap
  {
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IIdentityManagementServiceSoap/GetUserIdentity", ReplyAction = "http://sso.sage.com/IIdentityManagementServiceSoap/GetUserIdentityResponse")]
    GetUserIdentityResponse GetUserIdentity(GetUserIdentityRequest request);

    [OperationContract(Action = "http://sso.sage.com/IIdentityManagementServiceSoap/CreateUserIdentity", ReplyAction = "http://sso.sage.com/IIdentityManagementServiceSoap/CreateUserIdentityResponse")]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    CreateUserIdentityResponse CreateUserIdentity(CreateUserIdentityRequest request);

    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IIdentityManagementServiceSoap/UpdateUserIdentity", ReplyAction = "http://sso.sage.com/IIdentityManagementServiceSoap/UpdateUserIdentityResponse")]
    [ServiceKnownType(typeof (Principal))]
    UpdateUserIdentityResponse UpdateUserIdentity(UpdateUserIdentityRequest request);

    [ServiceKnownType(typeof (Principal))]
    [XmlSerializerFormat]
    [OperationContract(Action = "http://sso.sage.com/IIdentityManagementServiceSoap/DeleteUserIdentity", ReplyAction = "http://sso.sage.com/IIdentityManagementServiceSoap/DeleteUserIdentityResponse")]
    [ServiceKnownType(typeof (Updateable))]
    void DeleteUserIdentity(DeleteUserIdentityRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IIdentityManagementServiceSoap/ListUserIdentities", ReplyAction = "http://sso.sage.com/IIdentityManagementServiceSoap/ListUserIdentitiesResponse")]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    ListUserIdentitiesResponse ListUserIdentities(ListUserIdentitiesRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    [OperationContract(Action = "http://sso.sage.com/IIdentityManagementServiceSoap/GetX509Identity", ReplyAction = "http://sso.sage.com/IIdentityManagementServiceSoap/GetX509IdentityResponse")]
    [XmlSerializerFormat]
    GetX509IdentityResponse GetX509Identity(GetX509IdentityRequest request);

    [OperationContract(Action = "http://sso.sage.com/IIdentityManagementServiceSoap/CreateX509Identity", ReplyAction = "http://sso.sage.com/IIdentityManagementServiceSoap/CreateX509IdentityResponse")]
    [ServiceKnownType(typeof (Principal))]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    CreateX509IdentityResponse CreateX509Identity(CreateX509IdentityRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    [XmlSerializerFormat]
    [OperationContract(Action = "http://sso.sage.com/IIdentityManagementServiceSoap/UpdateX509Identity", ReplyAction = "http://sso.sage.com/IIdentityManagementServiceSoap/UpdateX509IdentityResponse")]
    UpdateX509IdentityResponse UpdateX509Identity(UpdateX509IdentityRequest request);

    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    [OperationContract(Action = "http://sso.sage.com/IIdentityManagementServiceSoap/DeleteX509Identity", ReplyAction = "http://sso.sage.com/IIdentityManagementServiceSoap/DeleteX509IdentityResponse")]
    [ServiceKnownType(typeof (Updateable))]
    void DeleteX509Identity(DeleteX509IdentityRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    [OperationContract(Action = "http://sso.sage.com/IIdentityManagementServiceSoap/GetSecretKeyIdentity", ReplyAction = "http://sso.sage.com/IIdentityManagementServiceSoap/GetSecretKeyIdentityResponse")]
    GetSecretKeyIdentityResponse GetSecretKeyIdentity(GetSecretKeyIdentityRequest request);

    [ServiceKnownType(typeof (Principal))]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    [OperationContract(Action = "http://sso.sage.com/IIdentityManagementServiceSoap/CreateSecretKeyIdentity", ReplyAction = "http://sso.sage.com/IIdentityManagementServiceSoap/CreateSecretKeyIdentityResponse")]
    CreateSecretKeyIdentityResponse CreateSecretKeyIdentity(CreateSecretKeyIdentityRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IIdentityManagementServiceSoap/UpdateSecretKeyIdentity", ReplyAction = "http://sso.sage.com/IIdentityManagementServiceSoap/UpdateSecretKeyIdentityResponse")]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    UpdateSecretKeyIdentityResponse UpdateSecretKeyIdentity(UpdateSecretKeyIdentityRequest request);

    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IIdentityManagementServiceSoap/DeleteSecretKeyIdentity", ReplyAction = "http://sso.sage.com/IIdentityManagementServiceSoap/DeleteSecretKeyIdentityResponse")]
    void DeleteSecretKeyIdentity(DeleteSecretKeyIdentityRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    [OperationContract(Action = "http://sso.sage.com/IIdentityManagementServiceSoap/ListSecretKeyIdentities", ReplyAction = "http://sso.sage.com/IIdentityManagementServiceSoap/ListSecretKeyIdentitiesResponse")]
    [XmlSerializerFormat]
    ListSecretKeyIdentitiesResponse ListSecretKeyIdentities();
  }
}
