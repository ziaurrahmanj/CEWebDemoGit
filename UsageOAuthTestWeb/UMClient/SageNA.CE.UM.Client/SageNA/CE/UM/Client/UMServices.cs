// Type: SageNA.CE.UM.Client.UMServices
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using CEDataService;
using SageNA.CE.CEDataServiceClient;
using SageNA.CE.UMClientInterface;
using System;

namespace SageNA.CE.UM.Client
{
  public class UMServices : IUMServices
  {
    private AppConfig _AppConfig;

    private CEUMRepositoryClient UMRepositoryClient
    {
      get
      {
        SSOServiceCallHelper.InitServicePointManager();
        return new CEUMRepositoryClient(this._AppConfig.RepositoryEndPointConfig);
      }
    }

    public UMServices()
    {
      this._AppConfig = ConfigHelper.DefaultConfig;
    }

    public UMServices(AppConfig appConfig)
    {
      this._AppConfig = appConfig;
    }

    public PersonAccessInfo GetAccessInfoBySageId(Guid productId, Guid appId, Guid sageIdentityId, bool validOnly)
    {
      return this.UMRepositoryClient.GetAccessInfoBySageId(productId, appId, sageIdentityId, validOnly);
    }

    public PersonAccessInfo GetAccessInfoByEmail(Guid productId, Guid appId, string email, bool validOnly)
    {
      return this.UMRepositoryClient.GetAccessInfoByEmail(productId, appId, email, validOnly);
    }

    public PersonAccessInfo GetAccessInfoByProductUser(Guid appId, Guid productUserId, bool validOnly)
    {
      return this.UMRepositoryClient.GetAccessInfoByProductUser(appId, productUserId, validOnly);
    }

    public PersonAccessInfo StartWebSession(Guid productId, Guid appId, Guid sageIdentityId, string sessionId, bool validOnly)
    {
      return this.UMRepositoryClient.StartWebSession(productId, appId, sageIdentityId, sessionId, validOnly);
    }

    public void EndWebSession(string sessionId)
    {
      this.UMRepositoryClient.EndWebSession(sessionId);
    }

    public PersonAccessInfo StartUserInvitation(Guid productUserId)
    {
      return this.UMRepositoryClient.StartUserInvitation(productUserId);
    }

    public void AssociateUser(Guid productUserId, Guid sageIdentityId)
    {
      this.UMRepositoryClient.AssociateUser(productUserId, sageIdentityId);
    }

    public void ConfirmUser(Guid productUserId)
    {
      this.UMRepositoryClient.ConfirmUser(productUserId);
    }

    public PersonAccessInfo StartAppTenantProvisioning(string provisioningCode)
    {
      return this.UMRepositoryClient.StartAppTenantProvisioning(provisioningCode);
    }

    public void UpdateAdminInfo(string provisioningCode, Person updatedPersonInfo)
    {
      this.UMRepositoryClient.UpdateAdminInfo(provisioningCode, updatedPersonInfo);
    }

    public void UpdateProvisioningStatus(string provisioningCode, Guid tenantProvisioningStatus)
    {
      this.UMRepositoryClient.UpdateProvisioningStatus(provisioningCode, tenantProvisioningStatus);
    }

    public TenantApp GetTenantAppByTenantId(Guid appId, Guid tenantId, bool validOnly)
    {
      return this.UMRepositoryClient.GetTenantAppByTenantId(appId, tenantId, validOnly);
    }
  }
}
