// Type: SageSSO.ServiceReferences.WebApplicationEmailConfiguration
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [Serializable]
  public class WebApplicationEmailConfiguration
  {
    private long idField;
    private bool idFieldSpecified;
    private string templateNameField;
    private string fromAddressField;
    private string fromNameField;
    private CultureSpecificValue[] subjectNamesField;

    [XmlElement(Order = 0)]
    public long Id
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

    [XmlElement(Order = 2)]
    public string FromAddress
    {
      get
      {
        return this.fromAddressField;
      }
      set
      {
        this.fromAddressField = value;
      }
    }

    [XmlElement(Order = 3)]
    public string FromName
    {
      get
      {
        return this.fromNameField;
      }
      set
      {
        this.fromNameField = value;
      }
    }

    [XmlElement("SubjectNames", Order = 4)]
    public CultureSpecificValue[] SubjectNames
    {
      get
      {
        return this.subjectNamesField;
      }
      set
      {
        this.subjectNamesField = value;
      }
    }
  }
}
