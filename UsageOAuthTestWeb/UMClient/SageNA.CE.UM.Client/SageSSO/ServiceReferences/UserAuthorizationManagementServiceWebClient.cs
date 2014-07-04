// Type: SageSSO.ServiceReferences.UserAuthorizationManagementServiceWebClient
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
  public class UserAuthorizationManagementServiceWebClient : ClientBase<IUserAuthorizationManagementServiceWeb>, IUserAuthorizationManagementServiceWeb
  {
    public UserAuthorizationManagementServiceWebClient()
    {
    }

    public UserAuthorizationManagementServiceWebClient(string endpointConfigurationName)
      : base(endpointConfigurationName)
    {
    }

    public UserAuthorizationManagementServiceWebClient(string endpointConfigurationName, string remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public UserAuthorizationManagementServiceWebClient(string endpointConfigurationName, EndpointAddress remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public UserAuthorizationManagementServiceWebClient(Binding binding, EndpointAddress remoteAddress)
      : base(binding, remoteAddress)
    {
    }

    public GetAuthorizationSummaryResponse WebGetAuthorizationSummary(GetAuthorizationSummaryRequest request)
    {
      return this.Channel.WebGetAuthorizationSummary(request);
    }

    public GetAuthorizedClientsResponse WebGetAuthorizedClients(GetAuthorizedClientsRequest request)
    {
      return this.Channel.WebGetAuthorizedClients(request);
    }

    public GetAuthorizationsForClientResponse WebGetAuthorizationsForClient(GetAuthorizationsForClientRequest request)
    {
      return this.Channel.WebGetAuthorizationsForClient(request);
    }

    public void WebRevokeAuthorization(RevokeAuthorizationRequest request)
    {
      this.Channel.WebRevokeAuthorization(request);
    }
  }
}
