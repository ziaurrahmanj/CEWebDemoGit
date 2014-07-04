// Type: SageSSO.ServiceReferences.EndPasswordRecoveryAttemptRequest
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
  public class EndPasswordRecoveryAttemptRequest
  {
    private Guid resultIdField;

    [XmlElement(Order = 0)]
    public Guid ResultId
    {
      get
      {
        return this.resultIdField;
      }
      set
      {
        this.resultIdField = value;
      }
    }
  }
}
