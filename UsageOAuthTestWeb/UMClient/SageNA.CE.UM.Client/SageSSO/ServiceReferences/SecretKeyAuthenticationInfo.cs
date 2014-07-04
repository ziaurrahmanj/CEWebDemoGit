// Type: SageSSO.ServiceReferences.SecretKeyAuthenticationInfo
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [XmlType(Namespace = "http://sso.sage.com")]
  [Serializable]
  public class SecretKeyAuthenticationInfo
  {
    private string nameField;
    private string keyField;

    [XmlElement(Order = 0)]
    public string Name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    [XmlElement(Order = 1)]
    public string Key
    {
      get
      {
        return this.keyField;
      }
      set
      {
        this.keyField = value;
      }
    }
  }
}
