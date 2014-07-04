// Type: SageNA.CE.UM.Client.ConfigHelper
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using Microsoft.WindowsAzure;
using SageNA.CE.UMClientInterface;
using System;

namespace SageNA.CE.UM.Client
{
  public static class ConfigHelper
  {
    public static AppConfig DefaultConfig = ConfigHelper.LoadDefaultConfig();

    static ConfigHelper()
    {
    }

    private static AppConfig LoadDefaultConfig()
    {
      AppConfig appConfig = new AppConfig();
      appConfig.AppBaseUri = ConfigHelper.GetSetting("CEServerBaseUri");
      appConfig.ProductId = Guid.Parse(ConfigHelper.GetSetting("CEProductId"));
      appConfig.ApplicationId = Guid.Parse(ConfigHelper.GetSetting("CEApplicationId"));
      appConfig.RepositoryEndPointConfig = ConfigHelper.GetSetting("CERepositoryEndPointConfig");
      appConfig.DefaultTemplate = ConfigHelper.GetSetting("SageIdDefaultTemplate");
      appConfig.MobileTemplate = ConfigHelper.GetSetting("SageIdDefaultMobileTemplate");
      int result1;
      if (!int.TryParse(ConfigHelper.GetSetting("SageIdSessionTimeoutMinutes"), out result1))
        result1 = 20;
      appConfig.SessionTimeoutMinutes = result1;
      int result2;
      if (!int.TryParse(ConfigHelper.GetSetting("SageIdServiceCallTimeOutSecs"), out result2))
        result2 = 60;
      appConfig.ServiceCallTimeOutSecs = result2;
      appConfig.LogonResultUrl = ConfigHelper.GetSetting("CELogonResultUrl");
      appConfig.SageIdClientConfig = ConfigHelper.GetSetting("SageIdClientConfig");
      appConfig.SageIdClientConfigIM = ConfigHelper.GetSetting("SageIdClientConfigIM");
      appConfig.SageIdClientConfigAM = ConfigHelper.GetSetting("SageIdClientConfigAM");
      appConfig.EncryptionKey = ConfigHelper.GetSetting("SageIdAccessTokenEncryptionKey");
      bool result3;
      if (!bool.TryParse(ConfigHelper.GetSetting("CEEnableTrace"), out result3))
        result3 = false;
      appConfig.EnableTrace = result3;
      appConfig.InitializationVector = ConfigHelper.GetSetting("SageIdAccessTokenEncryptionInitialisationVector");
      bool result4;
      if (!bool.TryParse(ConfigHelper.GetSetting("SageIdAccessTokenEncryptionOn"), out result4))
        result4 = true;
      appConfig.UseEncryptedToken = result4;
      appConfig.RootCertificateFindType = ConfigHelper.GetSetting("SageIdSSORootCertificateFindType");
      if (appConfig.RootCertificateFindType == string.Empty)
        appConfig.RootCertificateFindType = "FindBySubjectName";
      appConfig.RootCertificateFindValue = ConfigHelper.GetSetting("SageIdSSORootCertificateFindValue");
      int result5;
      if (!int.TryParse(ConfigHelper.GetSetting("SageIdServerTimeAdjustmentGracePeriodSeconds"), out result5))
        result5 = 45;
      appConfig.ServerTimeAdjustmentGracePeriodSeconds = result5;
      bool result6;
      if (!bool.TryParse(ConfigHelper.GetSetting("CEUsesAutoRegistration"), out result6))
        result6 = false;
      appConfig.UsesAutoRegistration = result6;
      return appConfig;
    }

    private static string GetSetting(string key)
    {
      string str;
      try
      {
        str = CloudConfigurationManager.GetSetting(key) ?? string.Empty;
      }
      catch
      {
        str = string.Empty;
      }
      return str;
    }
  }
}
