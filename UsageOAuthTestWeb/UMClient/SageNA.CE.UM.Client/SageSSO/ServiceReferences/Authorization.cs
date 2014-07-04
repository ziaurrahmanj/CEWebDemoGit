// Type: SageSSO.ServiceReferences.Authorization
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
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://sso.sage.com")]
  [DesignerCategory("code")]
  [Serializable]
  public class Authorization
  {
    private AuthorizationPermissionSet[] permissionSetsField;
    private Guid idField;
    private DateTime grantedAtField;
    private DateTime expiresAtField;

    [XmlElement("PermissionSets", Order = 0)]
    public AuthorizationPermissionSet[] PermissionSets
    {
      get
      {
        return this.permissionSetsField;
      }
      set
      {
        this.permissionSetsField = value;
      }
    }

    [XmlElement(Order = 1)]
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

    [XmlElement(Order = 2)]
    public DateTime GrantedAt
    {
      get
      {
        return this.grantedAtField;
      }
      set
      {
        this.grantedAtField = value;
      }
    }

    [XmlElement(Order = 3)]
    public DateTime ExpiresAt
    {
      get
      {
        return this.expiresAtField;
      }
      set
      {
        this.expiresAtField = value;
      }
    }
  }
}
