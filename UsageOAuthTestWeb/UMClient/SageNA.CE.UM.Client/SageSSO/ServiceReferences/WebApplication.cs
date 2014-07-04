// Type: SageSSO.ServiceReferences.WebApplication
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://sso.sage.com")]
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [Serializable]
  public class WebApplication : Updateable
  {
    private Guid idField;
    private bool idFieldSpecified;
    private AutomaticSignOnMode automaticSignOnModeField;
    private bool automaticSignOnModeFieldSpecified;
    private CultureSpecificValue[] displayNamesField;
    private X509Principal x509PrincipalField;
    private string notificationUriField;
    private bool supportNonActivatedSignOnField;
    private bool supportNonActivatedSignOnFieldSpecified;
    private string templateNameField;
    private string captchaThemeField;
    private int maxAnonymousSignOnAttemptsBeforeCaptchaField;
    private bool maxAnonymousSignOnAttemptsBeforeCaptchaFieldSpecified;
    private int maxAnonymousSignOnAttemptsBeforeFailureField;
    private bool maxAnonymousSignOnAttemptsBeforeFailureFieldSpecified;
    private string accountPolicyNameField;
    private bool sendsOwnActivationEmailsField;
    private bool sendsOwnActivationEmailsFieldSpecified;
    private string activationLinkTimeoutField;
    private string activationLinkLingerField;
    private string activationExitUriField;
    private bool allowTransparentRegistrationField;
    private bool allowTransparentRegistrationFieldSpecified;
    private EmailConfiguration[] emailConfigurationField;
    private int notificationSubscriptionIdField;
    private bool notificationSubscriptionIdFieldSpecified;
    private string monikerField;
    private string opCoField;
    private string businessUnitField;

    [XmlElement(Order = 0)]
    public Guid Id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    [XmlIgnore]
    public bool IdSpecified
    {
      get
      {
        return this.idFieldSpecified;
      }
      set
      {
        this.idFieldSpecified = value;
      }
    }

    [XmlElement(Order = 1)]
    public AutomaticSignOnMode AutomaticSignOnMode
    {
      get
      {
        return this.automaticSignOnModeField;
      }
      set
      {
        this.automaticSignOnModeField = value;
      }
    }

    [XmlIgnore]
    public bool AutomaticSignOnModeSpecified
    {
      get
      {
        return this.automaticSignOnModeFieldSpecified;
      }
      set
      {
        this.automaticSignOnModeFieldSpecified = value;
      }
    }

    [XmlArrayItem("DisplayName", IsNullable = false)]
    [XmlArray(Order = 2)]
    public CultureSpecificValue[] DisplayNames
    {
      get
      {
        return this.displayNamesField;
      }
      set
      {
        this.displayNamesField = value;
      }
    }

    [XmlElement(Order = 3)]
    public X509Principal X509Principal
    {
      get
      {
        return this.x509PrincipalField;
      }
      set
      {
        this.x509PrincipalField = value;
      }
    }

    [XmlElement(Order = 4)]
    public string NotificationUri
    {
      get
      {
        return this.notificationUriField;
      }
      set
      {
        this.notificationUriField = value;
      }
    }

    [XmlElement(Order = 5)]
    public bool SupportNonActivatedSignOn
    {
      get
      {
        return this.supportNonActivatedSignOnField;
      }
      set
      {
        this.supportNonActivatedSignOnField = value;
      }
    }

    [XmlIgnore]
    public bool SupportNonActivatedSignOnSpecified
    {
      get
      {
        return this.supportNonActivatedSignOnFieldSpecified;
      }
      set
      {
        this.supportNonActivatedSignOnFieldSpecified = value;
      }
    }

    [XmlElement(Order = 6)]
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

    [XmlElement(Order = 7)]
    public string CaptchaTheme
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

    [XmlElement(Order = 8)]
    public int MaxAnonymousSignOnAttemptsBeforeCaptcha
    {
      get
      {
        return this.maxAnonymousSignOnAttemptsBeforeCaptchaField;
      }
      set
      {
        this.maxAnonymousSignOnAttemptsBeforeCaptchaField = value;
      }
    }

    [XmlIgnore]
    public bool MaxAnonymousSignOnAttemptsBeforeCaptchaSpecified
    {
      get
      {
        return this.maxAnonymousSignOnAttemptsBeforeCaptchaFieldSpecified;
      }
      set
      {
        this.maxAnonymousSignOnAttemptsBeforeCaptchaFieldSpecified = value;
      }
    }

    [XmlElement(Order = 9)]
    public int MaxAnonymousSignOnAttemptsBeforeFailure
    {
      get
      {
        return this.maxAnonymousSignOnAttemptsBeforeFailureField;
      }
      set
      {
        this.maxAnonymousSignOnAttemptsBeforeFailureField = value;
      }
    }

    [XmlIgnore]
    public bool MaxAnonymousSignOnAttemptsBeforeFailureSpecified
    {
      get
      {
        return this.maxAnonymousSignOnAttemptsBeforeFailureFieldSpecified;
      }
      set
      {
        this.maxAnonymousSignOnAttemptsBeforeFailureFieldSpecified = value;
      }
    }

    [XmlElement(Order = 10)]
    public string AccountPolicyName
    {
      get
      {
        return this.accountPolicyNameField;
      }
      set
      {
        this.accountPolicyNameField = value;
      }
    }

    [XmlElement(Order = 11)]
    public bool SendsOwnActivationEmails
    {
      get
      {
        return this.sendsOwnActivationEmailsField;
      }
      set
      {
        this.sendsOwnActivationEmailsField = value;
      }
    }

    [XmlIgnore]
    public bool SendsOwnActivationEmailsSpecified
    {
      get
      {
        return this.sendsOwnActivationEmailsFieldSpecified;
      }
      set
      {
        this.sendsOwnActivationEmailsFieldSpecified = value;
      }
    }

    [XmlElement(DataType = "duration", Order = 12)]
    public string ActivationLinkTimeout
    {
      get
      {
        return this.activationLinkTimeoutField;
      }
      set
      {
        this.activationLinkTimeoutField = value;
      }
    }

    [XmlElement(DataType = "duration", Order = 13)]
    public string ActivationLinkLinger
    {
      get
      {
        return this.activationLinkLingerField;
      }
      set
      {
        this.activationLinkLingerField = value;
      }
    }

    [XmlElement(Order = 14)]
    public string ActivationExitUri
    {
      get
      {
        return this.activationExitUriField;
      }
      set
      {
        this.activationExitUriField = value;
      }
    }

    [XmlElement(Order = 15)]
    public bool AllowTransparentRegistration
    {
      get
      {
        return this.allowTransparentRegistrationField;
      }
      set
      {
        this.allowTransparentRegistrationField = value;
      }
    }

    [XmlIgnore]
    public bool AllowTransparentRegistrationSpecified
    {
      get
      {
        return this.allowTransparentRegistrationFieldSpecified;
      }
      set
      {
        this.allowTransparentRegistrationFieldSpecified = value;
      }
    }

    [XmlElement("EmailConfiguration", Order = 16)]
    public EmailConfiguration[] EmailConfiguration
    {
      get
      {
        return this.emailConfigurationField;
      }
      set
      {
        this.emailConfigurationField = value;
      }
    }

    [XmlElement(Order = 17)]
    public int NotificationSubscriptionId
    {
      get
      {
        return this.notificationSubscriptionIdField;
      }
      set
      {
        this.notificationSubscriptionIdField = value;
      }
    }

    [XmlIgnore]
    public bool NotificationSubscriptionIdSpecified
    {
      get
      {
        return this.notificationSubscriptionIdFieldSpecified;
      }
      set
      {
        this.notificationSubscriptionIdFieldSpecified = value;
      }
    }

    [XmlElement(Order = 18)]
    public string Moniker
    {
      get
      {
        return this.monikerField;
      }
      set
      {
        this.monikerField = value;
      }
    }

    [XmlElement(Order = 19)]
    public string OpCo
    {
      get
      {
        return this.opCoField;
      }
      set
      {
        this.opCoField = value;
      }
    }

    [XmlElement(Order = 20)]
    public string BusinessUnit
    {
      get
      {
        return this.businessUnitField;
      }
      set
      {
        this.businessUnitField = value;
      }
    }
  }
}
