// Type: SageSSO.ServiceReferences.AuthorizationSummary
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
  public class AuthorizationSummary
  {
    private AuthorizationPermissionSet[] permissionSetsField;
    private Guid authorizationIdField;
    private string deviceNameField;
    private DateTime lastUsedField;

    [XmlArray(Order = 0)]
    [XmlArrayItem("PermissionSet", IsNullable = false)]
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
    public Guid AuthorizationId
    {
      get
      {
        return this.authorizationIdField;
      }
      set
      {
        this.authorizationIdField = value;
      }
    }

    [XmlElement(Order = 2)]
    public string DeviceName
    {
      get
      {
        return this.deviceNameField;
      }
      set
      {
        this.deviceNameField = value;
      }
    }

    [XmlElement(Order = 3)]
    public DateTime LastUsed
    {
      get
      {
        return this.lastUsedField;
      }
      set
      {
        this.lastUsedField = value;
      }
    }
  }
}
