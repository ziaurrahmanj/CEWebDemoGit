// Type: SageSSO.ServiceReferences.ExecuteScriptRequest
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
  [XmlType(Namespace = "http://sso.sage.com")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class ExecuteScriptRequest
  {
    private ScriptArgument[] argumentsField;
    private string scriptNameField;

    [XmlArray(Order = 0)]
    [XmlArrayItem("Argument")]
    public ScriptArgument[] Arguments
    {
      get
      {
        return this.argumentsField;
      }
      set
      {
        this.argumentsField = value;
      }
    }

    [XmlElement(Order = 1)]
    public string ScriptName
    {
      get
      {
        return this.scriptNameField;
      }
      set
      {
        this.scriptNameField = value;
      }
    }
  }
}
