// Type: SageSSO.ServiceReferences.ListUserIdentitiesRequest
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
  [XmlType(Namespace = "http://sso.sage.com")]
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [DesignerCategory("code")]
  [Serializable]
  public class ListUserIdentitiesRequest
  {
    private string filterField;
    private string filterFieldField;
    private int offsetField;
    private int countField;
    private ListSortOrder orderField;

    [XmlElement(IsNullable = true, Order = 0)]
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

    [XmlElement(IsNullable = true, Order = 1)]
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

    [XmlElement(Order = 2)]
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

    [XmlElement(Order = 3)]
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

    [XmlElement(Order = 4)]
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
