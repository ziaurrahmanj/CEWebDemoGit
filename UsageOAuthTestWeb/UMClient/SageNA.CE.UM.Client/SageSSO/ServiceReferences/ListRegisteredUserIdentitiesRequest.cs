// Type: SageSSO.ServiceReferences.ListRegisteredUserIdentitiesRequest
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://sso.sage.com")]
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [Serializable]
  public class ListRegisteredUserIdentitiesRequest
  {
    private Guid[] webApplicationIdsField;
    private string filterField;
    private string filterFieldField;
    private int offsetField;
    private int countField;
    private ListSortOrder orderField;

    [XmlArrayItem("WebApplicationId", IsNullable = false)]
    [XmlArray(Order = 0)]
    public Guid[] WebApplicationIds
    {
      get
      {
        return this.webApplicationIdsField;
      }
      set
      {
        this.webApplicationIdsField = value;
      }
    }

    [XmlElement(IsNullable = true, Order = 1)]
    public string Filter
    {
      get
      {
        return this.filterField;
      }
      set
      {
        this.filterField = value;
      }
    }

    [XmlElement(IsNullable = true, Order = 2)]
    public string FilterField
    {
      get
      {
        return this.filterFieldField;
      }
      set
      {
        this.filterFieldField = value;
      }
    }

    [XmlElement(Order = 3)]
    public int Offset
    {
      get
      {
        return this.offsetField;
      }
      set
      {
        this.offsetField = value;
      }
    }

    [XmlElement(Order = 4)]
    public int Count
    {
      get
      {
        return this.countField;
      }
      set
      {
        this.countField = value;
      }
    }

    [XmlElement(Order = 5)]
    public ListSortOrder Order
    {
      get
      {
        return this.orderField;
      }
      set
      {
        this.orderField = value;
      }
    }
  }
}
