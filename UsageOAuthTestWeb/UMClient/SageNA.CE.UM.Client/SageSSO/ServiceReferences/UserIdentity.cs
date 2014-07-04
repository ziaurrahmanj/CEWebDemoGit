// Type: SageSSO.ServiceReferences.UserIdentity
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
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://sso.sage.com")]
  [Serializable]
  public class UserIdentity : Identity
  {
    private PassportInfo passportInfoField;
    private string emailAddressField;
    private string nameField;
    private string passwordField;
    private string accountPolicyNameField;

    [XmlElement(IsNullable = true, Order = 0)]
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

    [XmlElement(Order = 1)]
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

    [XmlElement(IsNullable = true, Order = 2)]
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

    [XmlElement(IsNullable = true, Order = 3)]
    public string Password
    {
      get
      {
        return this.passwordField;
      }
      set
      {
        this.passwordField = value;
      }
    }

    [XmlElement(IsNullable = true, Order = 4)]
    public string AccountPolicyName
    {
      get
      {
        return this.accountPolicyNameField;
      }
      set
      {
        this.accountPolicyNameField = value;
      }
    }
  }
}
