// Type: SageSSO.ServiceReferences.UpdatePasswordWithActivationRequest
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
  public class UpdatePasswordWithActivationRequest
  {
    private Guid userIdentityIdField;
    private Guid webApplicationIdField;
    private string passwordField;
    private string templateNameField;
    private string cultureField;
    private bool forcePasswordChangeOnNextSignOnField;

    [XmlElement(Order = 0)]
    public Guid UserIdentityId
    {
      get
      {
        return this.userIdentityIdField;
      }
      set
      {
        this.userIdentityIdField = value;
      }
    }

    [XmlElement(Order = 1)]
    public Guid WebApplicationId
    {
      get
      {
        return this.webApplicationIdField;
      }
      set
      {
        this.webApplicationIdField = value;
      }
    }

    [XmlElement(Order = 2)]
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

    [XmlElement(Order = 3)]
    public string TemplateName
    {
      get
      {
        return this.templateNameField;
      }
      set
      {
        this.templateNameField = value;
      }
    }

    [XmlElement(Order = 4)]
    public string Culture
    {
      get
      {
        return this.cultureField;
      }
      set
      {
        this.cultureField = value;
      }
    }

    [XmlElement(Order = 5)]
    public bool ForcePasswordChangeOnNextSignOn
    {
      get
      {
        return this.forcePasswordChangeOnNextSignOnField;
      }
      set
      {
        this.forcePasswordChangeOnNextSignOnField = value;
      }
    }
  }
}
