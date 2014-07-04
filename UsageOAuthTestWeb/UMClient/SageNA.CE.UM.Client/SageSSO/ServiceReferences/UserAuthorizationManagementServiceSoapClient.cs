// Type: SageSSO.ServiceReferences.UserAuthorizationManagementServiceSoapClient
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace SageSSO.ServiceReferences
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "3.0.0.0")]
  public class UserAuthorizationManagementServiceSoapClient : ClientBase<IUserAuthorizationManagementServiceSoap>, IUserAuthorizationManagementServiceSoap
  {
    public UserAuthorizationManagementServiceSoapClient()
    {
    }

    public UserAuthorizationManagementServiceSoapClient(string endpointConfigurationName)
      : base(endpointConfigurationName)
    {
    }

    public UserAuthorizationManagementServiceSoapClient(string endpointConfigurationName, string remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public UserAuthorizationManagementServiceSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public UserAuthorizationManagementServiceSoapClient(Binding binding, EndpointAddress remoteAddress)
      : base(binding, remoteAddress)
    {
    }

    public GetAuthorizationSummaryResponse GetAuthorizationSummary(GetAuthorizationSummaryRequest request)
    {
      return this.Channel.GetAuthorizationSummary(request);
    }

    public GetAuthorizedClientsResponse GetAuthorizedClients(GetAuthorizedClientsRequest request)
    {
      return this.Channel.GetAuthorizedClients(request);
    }

    public GetAuthorizationsForClientResponse GetAuthorizationsForClient(GetAuthorizationsForClientRequest request)
    {
      return this.Channel.GetAuthorizationsForClient(request);
    }

    public void RevokeAuthorization(RevokeAuthorizationRequest request)
    {
      this.Channel.RevokeAuthorization(request);
    }
  }
}
