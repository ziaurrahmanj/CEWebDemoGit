// Type: SageNA.CE.UM.Client.OAuth.TokenDecryptionUtil
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace SageNA.CE.UM.Client.OAuth
{
  public static class TokenDecryptionUtil
  {
    private static X509Certificate2 oauthRootCertificate;

    public static X509Certificate2 OAuthCertificate
    {
      get
      {
        TokenDecryptionUtil.oauthRootCertificate = TokenDecryptionUtil.CertFromSecurityConfig(ConfigurationManager.AppSettings["SageIDOAuthRootCertificate"]);
        return TokenDecryptionUtil.oauthRootCertificate;
      }
    }

    private static X509Certificate2 CertFromSecurityConfig(string config)
    {
      Dictionary<string, string> dictionary = new Dictionary<string, string>((IEqualityComparer<string>) StringComparer.CurrentCultureIgnoreCase);
      string str1 = config;
      char[] chArray = new char[1]
      {
        ';'
      };
      foreach (string str2 in str1.Split(chArray))
      {
        int length = str2.IndexOf('=');
        if (length > 0)
          dictionary.Add(str2.Substring(0, length).Trim(), str2.Substring(length + 1).Trim());
      }
      if (dictionary.ContainsKey("CertData") && dictionary.ContainsKey("CertPwd"))
        return TokenDecryptionUtil.GetCertificateFromBase64AndPwd(dictionary["CertData"], dictionary["CertPwd"]);
      if (!dictionary.ContainsKey("CertName"))
        throw new Exception("Invalid certificate configuration string. Provide either 'CertStore=...;CertName=...', 'CertName=...' or 'CertData=...;CertPwd=...' parameters");
      bool userStore = true;
      if (dictionary.ContainsKey("CertStore") && !dictionary["CertStore"].StartsWith("User"))
        userStore = false;
      return TokenDecryptionUtil.GetCertificateFromStore(userStore, dictionary["CertName"]);
    }

    private static X509Certificate2 GetCertificateFromBase64AndPwd(string uuEncodedCedrt, string pwd)
    {
      return new X509Certificate2(Convert.FromBase64String(uuEncodedCedrt), pwd);
    }

    private static X509Certificate2 GetCertificateFromStore(bool userStore, string certName)
    {
      X509Store x509Store = new X509Store(userStore ? StoreLocation.CurrentUser : StoreLocation.LocalMachine);
      try
      {
        x509Store.Open(OpenFlags.ReadOnly);
        X509Certificate2Collection certificate2Collection = x509Store.Certificates.Find(X509FindType.FindByTimeValid, (object) DateTime.Now, false).Find(X509FindType.FindBySubjectDistinguishedName, (object) certName, false);
        if (certificate2Collection.Count == 0)
          return (X509Certificate2) null;
        else
          return certificate2Collection[0];
      }
      finally
      {
        x509Store.Close();
      }
    }

    internal static byte[] DecryptToken(string encryptionKey, string initialisationVector, byte[] cipherToken)
    {
      using (SymmetricAlgorithm symmetricAlgorithm = SymmetricAlgorithm.Create("AES"))
      {
        symmetricAlgorithm.Mode = CipherMode.CBC;
        symmetricAlgorithm.Padding = PaddingMode.PKCS7;
        symmetricAlgorithm.Key = Convert.FromBase64String(encryptionKey);
        symmetricAlgorithm.IV = Convert.FromBase64String(initialisationVector);
        byte[] numArray = (byte[]) null;
        using (ICryptoTransform decryptor = symmetricAlgorithm.CreateDecryptor())
          numArray = decryptor.TransformFinalBlock(cipherToken, 0, cipherToken.Length);
        return numArray;
      }
    }

    internal static void CheckNotificationValidSignature(X509Certificate2 certSageIdRoot, XmlDocument notification)
    {
      SignedXml signedXml = new SignedXml(notification);
      XmlNodeList elementsByTagName = notification.GetElementsByTagName("Signature", "http://www.w3.org/2000/09/xmldsig#");
      if (elementsByTagName.Count != 1)
        throw new Exception("Token was not signed.");
      signedXml.LoadXml((XmlElement) elementsByTagName[0]);
      if (!signedXml.CheckSignature(certSageIdRoot, true))
        throw new Exception("Invalid token signature.");
    }
  }
}
