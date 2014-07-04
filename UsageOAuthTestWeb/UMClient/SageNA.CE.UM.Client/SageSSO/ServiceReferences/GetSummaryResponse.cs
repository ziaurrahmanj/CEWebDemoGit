// Type: SageSSO.ServiceReferences.GetSummaryResponse
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
  public class GetSummaryResponse
  {
    private WebApplicationRegistrationSummary[] webApplicationsField;
    private DateTime dateCreatedField;
    private EffectiveState effectiveStateField;
    private DateTime? softLockExpiryDateField;
    private DateTime? gracePeriodExpiryDateField;
    private ActivationStatus activationStatusField;
    private DateTime? dateActivatedField;
    private DateTime? expiryDueDateField;

    [XmlArray(Order = 0)]
    [XmlArrayItem("WebApplicationRegistration", IsNullable = false)]
    public WebApplicationRegistrationSummary[] WebApplications
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

    [XmlElement(Order = 1)]
    public DateTime DateCreated
    {
      get
      {
        return this.dateCreatedField;
      }
      set
      {
        this.dateCreatedField = value;
      }
    }

    [XmlElement(Order = 2)]
    public EffectiveState EffectiveState
    {
      get
      {
        return this.effectiveStateField;
      }
      set
      {
        this.effectiveStateField = value;
      }
    }

    [XmlElement(IsNullable = true, Order = 3)]
    public DateTime? SoftLockExpiryDate
    {
      get
      {
        return this.softLockExpiryDateField;
      }
      set
      {
        this.softLockExpiryDateField = value;
      }
    }

    [XmlElement(IsNullable = true, Order = 4)]
    public DateTime? GracePeriodExpiryDate
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

    [XmlElement(Order = 5)]
    public ActivationStatus ActivationStatus
    {
      get
      {
        return this.activationStatusField;
      }
      set
      {
        this.activationStatusField = value;
      }
    }

    [XmlElement(IsNullable = true, Order = 6)]
    public DateTime? DateActivated
    {
      get
      {
        return this.dateActivatedField;
      }
      set
      {
        this.dateActivatedField = value;
      }
    }

    [XmlElement(IsNullable = true, Order = 7)]
    public DateTime? ExpiryDueDate
    {
      get
      {
        return this.expiryDueDateField;
      }
      set
      {
        this.expiryDueDateField = value;
      }
    }
  }
}
