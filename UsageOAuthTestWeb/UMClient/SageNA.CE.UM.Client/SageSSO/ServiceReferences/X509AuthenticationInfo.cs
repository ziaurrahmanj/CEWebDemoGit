// Type: SageSSO.ServiceReferences.X509AuthenticationInfo
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
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [XmlType(Namespace = "http://sso.sage.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class X509AuthenticationInfo
  {
    private string subjectField;
    private string issuerField;

    [XmlElement(Order = 0)]
    public string Subject
    {
      get
      {
        return this.subjectField;
      }
      set
      {
        this.subjectField = value;
      }
    }

    [XmlElement(Order = 1)]
    public string Issuer
    {
      get
      {
        return this.issuerField;
      }
      set
      {
        this.issuerField = value;
      }
    }
  }
}
