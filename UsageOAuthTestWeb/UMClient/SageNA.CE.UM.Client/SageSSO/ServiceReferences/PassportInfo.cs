// Type: SageSSO.ServiceReferences.PassportInfo
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
  public class PassportInfo
  {
    private int operationIdField;
    private int memberIdField;

    [XmlElement(Order = 0)]
    public int OperationId
    {
      get
      {
        return this.operationIdField;
      }
      set
      {
        this.operationIdField = value;
      }
    }

    [XmlElement(Order = 1)]
    public int MemberId
    {
      get
      {
        return this.memberIdField;
      }
      set
      {
        this.memberIdField = value;
      }
    }
  }
}
