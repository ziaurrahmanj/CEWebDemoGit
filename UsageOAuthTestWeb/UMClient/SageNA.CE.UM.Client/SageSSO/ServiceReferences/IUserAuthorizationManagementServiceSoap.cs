// Type: SageSSO.ServiceReferences.IUserAuthorizationManagementServiceSoap
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System.CodeDom.Compiler;
using System.ServiceModel;

namespace SageSSO.ServiceReferences
{
  [GeneratedCode("System.ServiceModel", "3.0.0.0")]
  [ServiceContract(ConfigurationName = "SageSSO.ServiceReferences.IUserAuthorizationManagementServiceSoap", Namespace = "http://sso.sage.com")]
  public interface IUserAuthorizationManagementServiceSoap
  {
    [OperationContract(Action = "http://sso.sage.com/IUserAuthorizationManagementServiceSoap/GetAuthorizationSummary", ReplyAction = "http://sso.sage.com/IUserAuthorizationManagementServiceSoap/GetAuthorizationSummaryResponse")]
    [ServiceKnownType(typeof (Principal))]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    GetAuthorizationSummaryResponse GetAuthorizationSummary(GetAuthorizationSummaryRequest request);

    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IUserAuthorizationManagementServiceSoap/GetAuthorizedClients", ReplyAction = "http://sso.sage.com/IUserAuthorizationManagementServiceSoap/GetAuthorizedClientsResponse")]
    [ServiceKnownType(typeof (Principal))]
    [XmlSerializerFormat]
    GetAuthorizedClientsResponse GetAuthorizedClients(GetAuthorizedClientsRequest request);

    [XmlSerializerFormat]
    [OperationContract(Action = "http://sso.sage.com/IUserAuthorizationManagementServiceSoap/GetAuthorizationsForClient", ReplyAction = "http://sso.sage.com/IUserAuthorizationManagementServiceSoap/GetAuthorizationsForClientResponse")]
    [ServiceKnownType(typeof (Principal))]
    [ServiceKnownType(typeof (Updateable))]
    GetAuthorizationsForClientResponse GetAuthorizationsForClient(GetAuthorizationsForClientRequest request);

    [XmlSerializerFormat]
    [OperationContract(Action = "http://sso.sage.com/IUserAuthorizationManagementServiceSoap/RevokeAuthorization", ReplyAction = "http://sso.sage.com/IUserAuthorizationManagementServiceSoap/RevokeAuthorizationResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    void RevokeAuthorization(RevokeAuthorizationRequest request);
  }
}
