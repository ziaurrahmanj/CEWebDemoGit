// Type: SageSSO.ServiceReferences.GetRegisteredWebApplicationsResponse
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
  [XmlType(Namespace = "http://sso.sage.com")]
  [DebuggerStepThrough]
  [Serializable]
  public class GetRegisteredWebApplicationsResponse
  {
    private WebApplicationInfo[] webApplicationsField;

    [XmlArray(Order = 0)]
    [XmlArrayItem("WebApplication", IsNullable = false)]
    public WebApplicationInfo[] WebApplications
    {
      get
      {
        return this.webApplicationsField;
      }
      set
      {
        this.webApplicationsField = value;
      }
    }
  }
}
