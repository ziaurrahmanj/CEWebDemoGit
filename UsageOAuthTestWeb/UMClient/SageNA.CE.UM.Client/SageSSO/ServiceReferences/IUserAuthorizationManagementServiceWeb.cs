// Type: SageSSO.ServiceReferences.IUserAuthorizationManagementServiceWeb
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System.CodeDom.Compiler;
using System.ServiceModel;

namespace SageSSO.ServiceReferences
{
  [ServiceContract(ConfigurationName = "SageSSO.ServiceReferences.IUserAuthorizationManagementServiceWeb", Namespace = "http://sso.sage.com")]
  [GeneratedCode("System.ServiceModel", "3.0.0.0")]
  public interface IUserAuthorizationManagementServiceWeb
  {
    [ServiceKnownType(typeof (Updateable))]
    [ServiceKnownType(typeof (Principal))]
    [OperationContract(Action = "http://sso.sage.com/IUserAuthorizationManagementServiceWeb/WebGetAuthorizationSummary", ReplyAction = "http://sso.sage.com/IUserAuthorizationManagementServiceWeb/WebGetAuthorizationSummaryResponse")]
    [XmlSerializerFormat]
    GetAuthorizationSummaryResponse WebGetAuthorizationSummary(GetAuthorizationSummaryRequest request);

    [ServiceKnownType(typeof (Principal))]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Updateable))]
    [OperationContract(Action = "http://sso.sage.com/IUserAuthorizationManagementServiceWeb/WebGetAuthorizedClients", ReplyAction = "http://sso.sage.com/IUserAuthorizationManagementServiceWeb/WebGetAuthorizedClientsResponse")]
    GetAuthorizedClientsResponse WebGetAuthorizedClients(GetAuthorizedClientsRequest request);

    [OperationContract(Action = "http://sso.sage.com/IUserAuthorizationManagementServiceWeb/WebGetAuthorizationsForClient", ReplyAction = "http://sso.sage.com/IUserAuthorizationManagementServiceWeb/WebGetAuthorizationsForClientResponse")]
    [ServiceKnownType(typeof (Updateable))]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Principal))]
    GetAuthorizationsForClientResponse WebGetAuthorizationsForClient(GetAuthorizationsForClientRequest request);

    [ServiceKnownType(typeof (Principal))]
    [OperationContract(Action = "http://sso.sage.com/IUserAuthorizationManagementServiceWeb/WebRevokeAuthorization", ReplyAction = "http://sso.sage.com/IUserAuthorizationManagementServiceWeb/WebRevokeAuthorizationResponse")]
    [XmlSerializerFormat]
    [ServiceKnownType(typeof (Updateable))]
    void WebRevokeAuthorization(RevokeAuthorizationRequest request);
  }
}
