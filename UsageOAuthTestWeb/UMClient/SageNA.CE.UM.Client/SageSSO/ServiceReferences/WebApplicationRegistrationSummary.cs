// Type: SageSSO.ServiceReferences.WebApplicationRegistrationSummary
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://sso.sage.com")]
  [Serializable]
  public class WebApplicationRegistrationSummary
  {
    private CultureSpecificValue[] displayNamesField;
    private Guid webApplicationIdField;
    private bool enabledField;

    [XmlArray(Order = 0)]
    [XmlArrayItem("DisplayName", IsNullable = false)]
    public CultureSpecificValue[] DisplayNames
    {
      get
      {
        return this.displayNamesField;
      }
      set
      {
        this.displayNamesField = value;
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
    public bool Enabled
    {
      get
      {
        return this.enabledField;
      }
      set
      {
        this.enabledField = value;
      }
    }
  }
}
