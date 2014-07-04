// Type: SageSSO.ServiceReferences.UserAccountPolicy
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://sso.sage.com")]
  [Serializable]
  public class UserAccountPolicy : Updateable
  {
    private Guid idField;
    private bool idFieldSpecified;
    private DateTime dateCreatedField;
    private bool dateCreatedFieldSpecified;
    private string nameField;
    private int rankField;
    private bool rankFieldSpecified;
    private int failedPasswordRecoveryThresholdField;
    private bool failedPasswordRecoveryThresholdFieldSpecified;
    private int captchaThresholdField;
    private bool captchaThresholdFieldSpecified;
    private HardLockPolicy hardLockPolicyField;
    private SoftLockPolicyLockLevel[] softLockPolicyField;

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

    [XmlIgnore]
    public bool DateCreatedSpecified
    {
      get
      {
        return this.dateCreatedFieldSpecified;
      }
      set
      {
        this.dateCreatedFieldSpecified = value;
      }
    }

    [XmlElement(Order = 2)]
    public string Name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    [XmlElement(Order = 3)]
    public int Rank
    {
      get
      {
        return this.rankField;
      }
      set
      {
        this.rankField = value;
      }
    }

    [XmlIgnore]
    public bool RankSpecified
    {
      get
      {
        return this.rankFieldSpecified;
      }
      set
      {
        this.rankFieldSpecified = value;
      }
    }

    [XmlElement(Order = 4)]
    public int FailedPasswordRecoveryThreshold
    {
      get
      {
        return this.failedPasswordRecoveryThresholdField;
      }
      set
      {
        this.failedPasswordRecoveryThresholdField = value;
      }
    }

    [XmlIgnore]
    public bool FailedPasswordRecoveryThresholdSpecified
    {
      get
      {
        return this.failedPasswordRecoveryThresholdFieldSpecified;
      }
      set
      {
        this.failedPasswordRecoveryThresholdFieldSpecified = value;
      }
    }

    [XmlElement(Order = 5)]
    public int CaptchaThreshold
    {
      get
      {
        return this.captchaThresholdField;
      }
      set
      {
        this.captchaThresholdField = value;
      }
    }

    [XmlIgnore]
    public bool CaptchaThresholdSpecified
    {
      get
      {
        return this.captchaThresholdFieldSpecified;
      }
      set
      {
        this.captchaThresholdFieldSpecified = value;
      }
    }

    [XmlElement(Order = 6)]
    public HardLockPolicy HardLockPolicy
    {
      get
      {
        return this.hardLockPolicyField;
      }
      set
      {
        this.hardLockPolicyField = value;
      }
    }

    [XmlArrayItem("LockLevel", IsNullable = false)]
    [XmlArray(Order = 7)]
    public SoftLockPolicyLockLevel[] SoftLockPolicy
    {
      get
      {
        return this.softLockPolicyField;
      }
      set
      {
        this.softLockPolicyField = value;
      }
    }
  }
}
