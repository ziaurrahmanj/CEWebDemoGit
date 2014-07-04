// Type: SageSSO.ServiceReferences.RegistrationSuccessResult
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
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class RegistrationSuccessResult
  {
    private Guid identityIdField;
    private string emailAddressField;
    private string nameField;
    private bool userSignedOnField;
    private object itemField;
    private string activationLinkUriField;

    [XmlElement(Order = 0)]
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

    [XmlElement(Order = 2)]
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

    [XmlElement(Order = 3)]
    public bool UserSignedOn
    {
      get
      {
        return this.userSignedOnField;
      }
      set
      {
        this.userSignedOnField = value;
      }
    }

    [XmlElement("FailedResult", typeof (FailedResult), Order = 4)]
    [XmlElement("SuccessResult", typeof (SuccessResult), Order = 4)]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlElement(Order = 5)]
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
  }
}
