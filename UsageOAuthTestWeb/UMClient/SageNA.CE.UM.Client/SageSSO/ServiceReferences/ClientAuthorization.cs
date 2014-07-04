// Type: SageSSO.ServiceReferences.ClientAuthorization
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
  [XmlType(Namespace = "http://sso.sage.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class ClientAuthorization
  {
    private CultureSpecificValue[] clientApplicationNamesField;
    private ClientInstanceAuthorization[] clientInstanceAuthorizationsField;
    private string defaultClientApplicationNameField;
    private ClientType clientTypeField;

    [XmlArrayItem("ClientApplicationName", IsNullable = false)]
    [XmlArray(Order = 0)]
    public CultureSpecificValue[] ClientApplicationNames
    {
      get
      {
        return this.clientApplicationNamesField;
      }
      set
      {
        this.clientApplicationNamesField = value;
      }
    }

    [XmlArray(Order = 1)]
    [XmlArrayItem(IsNullable = false)]
    public ClientInstanceAuthorization[] ClientInstanceAuthorizations
    {
      get
      {
        return this.clientInstanceAuthorizationsField;
      }
      set
      {
        this.clientInstanceAuthorizationsField = value;
      }
    }

    [XmlElement(Order = 2)]
    public string DefaultClientApplicationName
    {
      get
      {
        return this.defaultClientApplicationNameField;
      }
      set
      {
        this.defaultClientApplicationNameField = value;
      }
    }

    [XmlElement(Order = 3)]
    public ClientType ClientType
    {
      get
      {
        return this.clientTypeField;
      }
      set
      {
        this.clientTypeField = value;
      }
    }
  }
}
