// Type: SageNA.CE.UM.Client.CertificateHelper
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System;
using System.Security.Cryptography.X509Certificates;

namespace SageNA.CE.UM.Client
{
  public static class CertificateHelper
  {
    public static X509Certificate2 GetCertificateFromFindCriteria(string certificateFindType, string findValue)
    {
      X509FindType result;
      if (!Enum.TryParse<X509FindType>(certificateFindType, true, out result))
        throw new ArgumentOutOfRangeException("certificateFindType", (object) certificateFindType, "Invalid certificate find type value.");
      else
        return CertificateHelper.GetCertificateFromFindCriteria(result, findValue);
    }

    public static X509Certificate2 GetCertificateFromFindCriteria(X509FindType findType, string findValue)
    {
      X509Certificate2 certificate = (X509Certificate2) null;
      bool flag = CertificateHelper.LoadCertFromStore(findType, findValue, ref certificate, StoreName.My, StoreLocation.LocalMachine);
      if (!flag)
        flag = CertificateHelper.LoadCertFromStore(findType, findValue, ref certificate, StoreName.Root, StoreLocation.LocalMachine);
      if (!flag)
        flag = CertificateHelper.LoadCertFromStore(findType, findValue, ref certificate, StoreName.My, StoreLocation.CurrentUser);
      if (!flag)
        throw new Exception(string.Format("Unable to load X.509 certificate using criteria {0}='{1}'.", (object) ((object) findType).ToString(), (object) findValue));
      else
        return certificate;
    }

    private static bool LoadCertFromStore(X509FindType findType, string findValue, ref X509Certificate2 certificate, StoreName store, StoreLocation location)
    {
      X509Store x509Store = new X509Store(store, location);
      x509Store.Open(OpenFlags.OpenExistingOnly);
      bool flag;
      try
      {
        X509Certificate2Collection certificate2Collection = x509Store.Certificates.Find(findType, (object) findValue, false);
        certificate = certificate2Collection[0];
        flag = true;
      }
      catch
      {
        flag = false;
      }
      finally
      {
        x509Store.Close();
      }
      return flag;
    }
  }
}
