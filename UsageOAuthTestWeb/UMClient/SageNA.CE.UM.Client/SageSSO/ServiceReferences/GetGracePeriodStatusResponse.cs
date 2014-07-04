// Type: SageSSO.ServiceReferences.GetGracePeriodStatusResponse
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
  public class GetGracePeriodStatusResponse
  {
    private bool withinGracePeriodField;
    private DateTime gracePeriodExpiryDateField;

    [XmlElement(Order = 0)]
    public bool WithinGracePeriod
    {
      get
      {
        return this.withinGracePeriodField;
      }
      set
      {
        this.withinGracePeriodField = value;
      }
    }

    [XmlElement(Order = 1)]
    public DateTime GracePeriodExpiryDate
    {
      get
      {
        return this.gracePeriodExpiryDateField;
      }
      set
      {
        this.gracePeriodExpiryDateField = value;
      }
    }
  }
}
