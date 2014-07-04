// Type: SageSSO.ServiceReferences.PasswordRecoveryFailedResult
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
  [DesignerCategory("code")]
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [DebuggerStepThrough]
  [Serializable]
  public class PasswordRecoveryFailedResult
  {
    private PasswordRecoveryFailureReason reasonField;

    [XmlElement(Order = 0)]
    public PasswordRecoveryFailureReason Reason
    {
      get
      {
        return this.reasonField;
      }
      set
      {
        this.reasonField = value;
      }
    }
  }
}
