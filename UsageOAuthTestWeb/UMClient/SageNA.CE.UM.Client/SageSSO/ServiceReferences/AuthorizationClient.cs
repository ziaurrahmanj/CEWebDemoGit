// Type: SageSSO.ServiceReferences.AuthorizationClient
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
  [XmlInclude(typeof (DesktopAuthorizationClient))]
  [XmlType(Namespace = "http://sso.sage.com")]
  [XmlInclude(typeof (MobileAuthorizationClient))]
  [XmlInclude(typeof (WebAuthorizationClient))]
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [DebuggerStepThrough]
  [Serializable]
  public class AuthorizationClient : Updateable
  {
    private Guid idField;
    private bool idFieldSpecified;
    private DateTime dateCreatedField;
    private bool dateCreatedFieldSpecified;
    private Guid webApplicationIdField;
    private string clientIdField;
    private string defaultRedirectUriField;
    private string[] redirectUrisField;
    private string defaultDisplayNameField;
    private CultureSpecificValue[] localisedDisplayNamesField;
    private bool allowSkipAuthorizationField;

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

    [XmlElement(Order = 3)]
    public string ClientId
    {
      get
      {
        return this.clientIdField;
      }
      set
      {
        this.clientIdField = value;
      }
    }

    [XmlElement(Order = 4)]
    public string DefaultRedirectUri
    {
      get
      {
        return this.defaultRedirectUriField;
      }
      set
      {
        this.defaultRedirectUriField = value;
      }
    }

    [XmlArray(Order = 5)]
    [XmlArrayItem("RedirectUri", IsNullable = false)]
    public string[] RedirectUris
    {
      get
      {
        return this.redirectUrisField;
      }
      set
      {
        this.redirectUrisField = value;
      }
    }

    [XmlElement(Order = 6)]
    public string DefaultDisplayName
    {
      get
      {
        return this.defaultDisplayNameField;
      }
      set
      {
        this.defaultDisplayNameField = value;
      }
    }

    [XmlArray(Order = 7)]
    [XmlArrayItem("DisplayName", IsNullable = false)]
    public CultureSpecificValue[] LocalisedDisplayNames
    {
      get
      {
        return this.localisedDisplayNamesField;
      }
      set
      {
        this.localisedDisplayNamesField = value;
      }
    }

    [XmlElement(Order = 8)]
    public bool AllowSkipAuthorization
    {
      get
      {
        return this.allowSkipAuthorizationField;
      }
      set
      {
        this.allowSkipAuthorizationField = value;
      }
    }
  }
}
