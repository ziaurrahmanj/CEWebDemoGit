// Type: SageSSO.ServiceReferences.SuccessResult
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
  public class SuccessResult
  {
    private string userAuthenticationTokenField;
    private Guid sessionIdField;
    private DateTime sessionExpiryField;
    private string emailAddressField;
    private string displayNameField;
    private Guid identityIdField;

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
    public Guid SessionId
    {
      get
      {
        return this.sessionIdField;
      }
      set
      {
        this.sessionIdField = value;
      }
    }

    [XmlElement(Order = 2)]
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

    [XmlElement(Order = 5)]
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
  }
}
