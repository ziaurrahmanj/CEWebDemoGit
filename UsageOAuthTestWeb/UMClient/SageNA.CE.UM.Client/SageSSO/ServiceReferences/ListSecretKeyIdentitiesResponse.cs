// Type: SageSSO.ServiceReferences.ListSecretKeyIdentitiesResponse
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SageSSO.ServiceReferences
{
  [XmlType(Namespace = "http://sso.sage.com")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [Serializable]
  public class ListSecretKeyIdentitiesResponse
  {
    private SecretKeyIdentity[] secretKeyIdentitiesField;
    private int totalField;

    [XmlArrayItem(IsNullable = false)]
    [XmlArray(Order = 0)]
    public SecretKeyIdentity[] SecretKeyIdentities
    {
      get
      {
        return this.secretKeyIdentitiesField;
      }
      set
      {
        this.secretKeyIdentitiesField = value;
      }
    }

    [XmlElement(Order = 1)]
    public int Total
    {
      get
      {
        return this.totalField;
      }
      set
      {
        this.totalField = value;
      }
    }
  }
}
