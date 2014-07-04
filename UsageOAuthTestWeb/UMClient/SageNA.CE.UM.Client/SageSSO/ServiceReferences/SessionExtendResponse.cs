// Type: SageSSO.ServiceReferences.SessionExtendResponse
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
  [XmlType(Namespace = "http://sso.sage.com")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class SessionExtendResponse
  {
    private string userAuthenticationTokenField;
    private DateTime sessionExpiryField;
    private bool expiryDueField;

    [XmlElement(Order = 0)]
    public string UserAuthenticationToken
    {
      get
      {
        return this.userAuthenticationTokenField;
      }
      set
      {
        this.userAuthenticationTokenField = value;
      }
    }

    [XmlElement(Order = 1)]
    public DateTime SessionExpiry
    {
      get
      {
        return this.sessionExpiryField;
      }
      set
      {
        this.sessionExpiryField = value;
      }
    }

    [XmlElement(Order = 2)]
    public bool ExpiryDue
    {
      get
      {
        return this.expiryDueField;
      }
      set
      {
        this.expiryDueField = value;
      }
    }
  }
}
