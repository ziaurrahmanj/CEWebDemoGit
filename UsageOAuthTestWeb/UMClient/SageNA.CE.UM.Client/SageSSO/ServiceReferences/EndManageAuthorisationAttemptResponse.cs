// Type: SageSSO.ServiceReferences.EndManageAuthorisationAttemptResponse
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
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class EndManageAuthorisationAttemptResponse
  {
    private Guid manageAuthorisationAttemptIdField;
    private object itemField;
    private string stateField;
    private string cultureField;

    [XmlElement(Order = 0)]
    public Guid ManageAuthorisationAttemptId
    {
      get
      {
        return this.manageAuthorisationAttemptIdField;
      }
      set
      {
        this.manageAuthorisationAttemptIdField = value;
      }
    }

    [XmlElement("ManageAuthorisationSuccessResult", typeof (ManageAuthorisationSuccessResult), Order = 1)]
    [XmlElement("ManageAuthorisationFailedResult", typeof (ManageAuthorisationFailedResult), Order = 1)]
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
