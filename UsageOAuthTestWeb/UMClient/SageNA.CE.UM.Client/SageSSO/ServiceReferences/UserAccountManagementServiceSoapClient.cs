// Type: SageSSO.ServiceReferences.UserAccountManagementServiceSoapClient
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
  public class UserAccountManagementServiceSoapClient : ClientBase<IUserAccountManagementServiceSoap>, IUserAccountManagementServiceSoap
  {
    public UserAccountManagementServiceSoapClient()
    {
    }

    public UserAccountManagementServiceSoapClient(string endpointConfigurationName)
      : base(endpointConfigurationName)
    {
    }

    public UserAccountManagementServiceSoapClient(string endpointConfigurationName, string remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public UserAccountManagementServiceSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public UserAccountManagementServiceSoapClient(Binding binding, EndpointAddress remoteAddress)
      : base(binding, remoteAddress)
    {
    }

    public GetSummaryResponse GetSummary(GetSummaryRequest request)
    {
      return this.Channel.GetSummary(request);
    }

    public GetEffectiveStateResponse GetEffectiveState(GetEffectiveStateRequest request)
    {
      return this.Channel.GetEffectiveState(request);
    }

    public void ApplyHardLock(ApplyHardLockRequest request)
    {
      this.Channel.ApplyHardLock(request);
    }

    public void RemoveLock(RemoveLockRequest request)
    {
      this.Channel.RemoveLock(request);
    }

    public void ApplySignOnBlock(ApplySignOnBlockRequest request)
    {
      this.Channel.ApplySignOnBlock(request);
    }

    public void RemoveSignOnBlock(RemoveSignOnBlockRequest request)
    {
      this.Channel.RemoveSignOnBlock(request);
    }

    public GetSignOnBlockStatusResponse GetSignOnBlockStatus(GetSignOnBlockStatusRequest request)
    {
      return this.Channel.GetSignOnBlockStatus(request);
    }

    public void MarkActivated(MarkActivatedRequest request)
    {
      this.Channel.MarkActivated(request);
    }

    public GetActivationStatusResponse GetActivationStatus(GetActivationStatusRequest request)
    {
      return this.Channel.GetActivationStatus(request);
    }

    public GetGracePeriodStatusResponse GetGracePeriodStatus(GetGracePeriodStatusRequest request)
    {
      return this.Channel.GetGracePeriodStatus(request);
    }

    public void ResendActivationEmail(ResendActivationEmailRequest request)
    {
      this.Channel.ResendActivationEmail(request);
    }

    public void RegisterForWebApplication(RegisterForWebApplicationRequest request)
    {
      this.Channel.RegisterForWebApplication(request);
    }

    public void UnregisterFromWebApplication(UnregisterFromWebApplicationRequest request)
    {
      this.Channel.UnregisterFromWebApplication(request);
    }

    public GetRegisteredWebApplicationsResponse GetRegisteredWebApplications(GetRegisteredWebApplicationsRequest request)
    {
      return this.Channel.GetRegisteredWebApplications(request);
    }

    public void ApplyWebApplicationAutoSignOn(ApplyWebApplicationAutoSignOnRequest request)
    {
      this.Channel.ApplyWebApplicationAutoSignOn(request);
    }

    public void RemoveWebApplicationAutoSignOn(RemoveWebApplicationAutoSignOnRequest request)
    {
      this.Channel.RemoveWebApplicationAutoSignOn(request);
    }

    public GetWebApplicationAutoSignOnStatusResponse GetWebApplicationAutoSignOnStatus(GetWebApplicationAutoSignOnStatusRequest request)
    {
      return this.Channel.GetWebApplicationAutoSignOnStatus(request);
    }

    public ListRegisteredUserIdentitiesResponse ListRegisteredUserIdentities(ListRegisteredUserIdentitiesRequest request)
    {
      return this.Channel.ListRegisteredUserIdentities(request);
    }

    public void UpdatePasswordWithActivation(UpdatePasswordWithActivationRequest request)
    {
      this.Channel.UpdatePasswordWithActivation(request);
    }

    public void MarkForcePasswordChangeOnNextSignOn(MarkForcePasswordChangeOnNextSignOnRequest request)
    {
      this.Channel.MarkForcePasswordChangeOnNextSignOn(request);
    }
  }
}
