// Type: SageSSO.ServiceReferences.EndPasswordChangeAttemptResponse
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
  public class EndPasswordChangeAttemptResponse
  {
    private Guid passwordChangeAttemptIdField;
    private object itemField;
    private string stateField;
    private string cultureField;

    [XmlElement(Order = 0)]
    public Guid PasswordChangeAttemptId
    {
      get
      {
        return this.passwordChangeAttemptIdField;
      }
      set
      {
        this.passwordChangeAttemptIdField = value;
      }
    }

    [XmlElement("PasswordChangeFailedResult", typeof (PasswordChangeFailedResult), Order = 1)]
    [XmlElement("PasswordChangeSuccessResult", typeof (PasswordChangeSuccessResult), Order = 1)]
    public object Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }

    [XmlElement(Order = 2)]
    public string State
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    [XmlElement(Order = 3)]
    public string Culture
    {
      get
      {
        return this.cultureField;
      }
      set
      {
        this.cultureField = value;
      }
    }
  }
}
