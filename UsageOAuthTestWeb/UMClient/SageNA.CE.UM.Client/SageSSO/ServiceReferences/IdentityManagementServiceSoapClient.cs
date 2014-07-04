// Type: SageSSO.ServiceReferences.IdentityManagementServiceSoapClient
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
  public class IdentityManagementServiceSoapClient : ClientBase<IIdentityManagementServiceSoap>, IIdentityManagementServiceSoap
  {
    public IdentityManagementServiceSoapClient()
    {
    }

    public IdentityManagementServiceSoapClient(string endpointConfigurationName)
      : base(endpointConfigurationName)
    {
    }

    public IdentityManagementServiceSoapClient(string endpointConfigurationName, string remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public IdentityManagementServiceSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public IdentityManagementServiceSoapClient(Binding binding, EndpointAddress remoteAddress)
      : base(binding, remoteAddress)
    {
    }

    public GetUserIdentityResponse GetUserIdentity(GetUserIdentityRequest request)
    {
      return this.Channel.GetUserIdentity(request);
    }

    public CreateUserIdentityResponse CreateUserIdentity(CreateUserIdentityRequest request)
    {
      return this.Channel.CreateUserIdentity(request);
    }

    public UpdateUserIdentityResponse UpdateUserIdentity(UpdateUserIdentityRequest request)
    {
      return this.Channel.UpdateUserIdentity(request);
    }

    public void DeleteUserIdentity(DeleteUserIdentityRequest request)
    {
      this.Channel.DeleteUserIdentity(request);
    }

    public ListUserIdentitiesResponse ListUserIdentities(ListUserIdentitiesRequest request)
    {
      return this.Channel.ListUserIdentities(request);
    }

    public GetX509IdentityResponse GetX509Identity(GetX509IdentityRequest request)
    {
      return this.Channel.GetX509Identity(request);
    }

    public CreateX509IdentityResponse CreateX509Identity(CreateX509IdentityRequest request)
    {
      return this.Channel.CreateX509Identity(request);
    }

    public UpdateX509IdentityResponse UpdateX509Identity(UpdateX509IdentityRequest request)
    {
      return this.Channel.UpdateX509Identity(request);
    }

    public void DeleteX509Identity(DeleteX509IdentityRequest request)
    {
      this.Channel.DeleteX509Identity(request);
    }

    public GetSecretKeyIdentityResponse GetSecretKeyIdentity(GetSecretKeyIdentityRequest request)
    {
      return this.Channel.GetSecretKeyIdentity(request);
    }

    public CreateSecretKeyIdentityResponse CreateSecretKeyIdentity(CreateSecretKeyIdentityRequest request)
    {
      return this.Channel.CreateSecretKeyIdentity(request);
    }

    public UpdateSecretKeyIdentityResponse UpdateSecretKeyIdentity(UpdateSecretKeyIdentityRequest request)
    {
      return this.Channel.UpdateSecretKeyIdentity(request);
    }

    public void DeleteSecretKeyIdentity(DeleteSecretKeyIdentityRequest request)
    {
      this.Channel.DeleteSecretKeyIdentity(request);
    }

    public ListSecretKeyIdentitiesResponse ListSecretKeyIdentities()
    {
      return this.Channel.ListSecretKeyIdentities();
    }
  }
}
