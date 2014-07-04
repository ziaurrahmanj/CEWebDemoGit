// Type: SageSSO.ServiceReferences.WebAuthorizationClient
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
  public class WebAuthorizationClient : AuthorizationClient
  {
    private AuthenticationType authenticationTypeField;
    private object itemField;

    [XmlElement(Order = 0)]
    public AuthenticationType AuthenticationType
    {
      get
      {
        return this.authenticationTypeField;
      }
      set
      {
        this.authenticationTypeField = value;
      }
    }

    [XmlElement("X509Authentication", typeof (X509AuthenticationInfo), Order = 1)]
    [XmlElement("SecretKeyAuthentication", typeof (SecretKeyAuthenticationInfo), Order = 1)]
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
  }
}
