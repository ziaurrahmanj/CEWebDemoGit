// Type: SageSSO.ServiceReferences.PasswordRecoverySuccessResult
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://sso.sage.com")]
  [Serializable]
  public class PasswordRecoverySuccessResult
  {
    private Guid userIdentityIdField;
    private string activationLinkUriField;

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
