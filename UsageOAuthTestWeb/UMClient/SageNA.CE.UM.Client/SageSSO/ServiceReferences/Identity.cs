// Type: SageSSO.ServiceReferences.Identity
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
  [XmlInclude(typeof (SecretKeyIdentity))]
  [XmlInclude(typeof (X509Identity))]
  [XmlInclude(typeof (UserIdentity))]
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://sso.sage.com")]
  [Serializable]
  public class Identity : Updateable
  {
    private Guid idField;
    private bool idFieldSpecified;
    private DateTime dateCreatedField;
    private bool dateCreatedFieldSpecified;
    private bool isSystemIdentityField;
    private bool isSystemIdentityFieldSpecified;

    [XmlElement(Order = 0)]
    public Guid Id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    [XmlIgnore]
    public bool IdSpecified
    {
      get
      {
        return this.idFieldSpecified;
      }
      set
      {
        this.idFieldSpecified = value;
      }
    }

    [XmlElement(Order = 1)]
    public DateTime DateCreated
    {
      get
      {
        return this.dateCreatedField;
      }
      set
      {
        this.dateCreatedField = value;
      }
    }

    [XmlIgnore]
    public bool DateCreatedSpecified
    {
      get
      {
        return this.dateCreatedFieldSpecified;
      }
      set
      {
        this.dateCreatedFieldSpecified = value;
      }
    }

    [XmlElement(Order = 2)]
    public bool IsSystemIdentity
    {
      get
      {
        return this.isSystemIdentityField;
      }
      set
      {
        this.isSystemIdentityField = value;
      }
    }

    [XmlIgnore]
    public bool IsSystemIdentitySpecified
    {
      get
      {
        return this.isSystemIdentityFieldSpecified;
      }
      set
      {
        this.isSystemIdentityFieldSpecified = value;
      }
    }
  }
}
