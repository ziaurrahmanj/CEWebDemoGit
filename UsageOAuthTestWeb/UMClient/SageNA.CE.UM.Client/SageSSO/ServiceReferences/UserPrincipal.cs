// Type: SageSSO.ServiceReferences.UserPrincipal
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://sso.sage.com")]
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [Serializable]
  public class UserPrincipal : Principal
  {
    private string emailAddressField;
    private PassportInfo passportInfoField;

    [XmlElement(Order = 0)]
    public string EmailAddress
    {
      get
      {
        return this.emailAddressField;
      }
      set
      {
        this.emailAddressField = value;
      }
    }

    [XmlElement(IsNullable = true, Order = 1)]
    public PassportInfo PassportInfo
    {
      get
      {
        return this.passportInfoField;
      }
      set
      {
        this.passportInfoField = value;
      }
    }
  }
}
