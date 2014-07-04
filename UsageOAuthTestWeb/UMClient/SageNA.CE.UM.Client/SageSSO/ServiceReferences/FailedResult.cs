// Type: SageSSO.ServiceReferences.FailedResult
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
  public class FailedResult
  {
    private FailureReason reasonField;
    private string activationLinkUriField;
    private Guid identityIdField;
    private bool identityIdFieldSpecified;
    private string emailAddressField;
    private string displayNameField;

    [XmlElement(Order = 0)]
    public FailureReason Reason
    {
      get
      {
        return this.reasonField;
      }
      set
      {
        this.reasonField = value;
      }
    }

    [XmlElement(Order = 1)]
    public string ActivationLinkUri
    {
      get
      {
        return this.activationLinkUriField;
      }
      set
      {
        this.activationLinkUriField = value;
      }
    }

    [XmlElement(Order = 2)]
    public Guid IdentityId
    {
      get
      {
        return this.identityIdField;
      }
      set
      {
        this.identityIdField = value;
      }
    }

    [XmlIgnore]
    public bool IdentityIdSpecified
    {
      get
      {
        return this.identityIdFieldSpecified;
      }
      set
      {
        this.identityIdFieldSpecified = value;
      }
    }

    [XmlElement(Order = 3)]
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

    [XmlElement(Order = 4)]
    public string DisplayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }
  }
}
