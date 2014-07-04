// Type: SageSSO.ServiceReferences.StartPasswordChangeAttemptRequest
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [Serializable]
  public class StartPasswordChangeAttemptRequest
  {
    private string successUriField;
    private string failureUriField;
    private bool cancelAllowedField;
    private string stateField;
    private string cultureField;
    private string templateNameField;
    private CaptchaTheme captchaThemeField;
    private string emailTemplateNameField;

    [XmlElement(Order = 0)]
    public string SuccessUri
    {
      get
      {
        return this.successUriField;
      }
      set
      {
        this.successUriField = value;
      }
    }

    [XmlElement(Order = 1)]
    public string FailureUri
    {
      get
      {
        return this.failureUriField;
      }
      set
      {
        this.failureUriField = value;
      }
    }

    [XmlElement(Order = 2)]
    public bool CancelAllowed
    {
      get
      {
        return this.cancelAllowedField;
      }
      set
      {
        this.cancelAllowedField = value;
      }
    }

    [XmlElement(Order = 3)]
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

    [XmlElement(Order = 4)]
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

    [XmlElement(Order = 5)]
    public string TemplateName
    {
      get
      {
        return this.templateNameField;
      }
      set
      {
        this.templateNameField = value;
      }
    }

    [XmlElement(Order = 6)]
    public CaptchaTheme CaptchaTheme
    {
      get
      {
        return this.captchaThemeField;
      }
      set
      {
        this.captchaThemeField = value;
      }
    }

    [XmlElement(Order = 7)]
    public string EmailTemplateName
    {
      get
      {
        return this.emailTemplateNameField;
      }
      set
      {
        this.emailTemplateNameField = value;
      }
    }
  }
}
