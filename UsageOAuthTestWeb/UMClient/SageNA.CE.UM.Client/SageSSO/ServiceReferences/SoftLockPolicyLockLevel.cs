// Type: SageSSO.ServiceReferences.SoftLockPolicyLockLevel
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://sso.sage.com")]
  [Serializable]
  public class SoftLockPolicyLockLevel
  {
    private int lockLevelField;
    private bool lockLevelFieldSpecified;
    private int failedAuthenticationThresholdField;
    private bool failedAuthenticationThresholdFieldSpecified;
    private string lockDurationField;

    [XmlElement(Order = 0)]
    public int LockLevel
    {
      get
      {
        return this.lockLevelField;
      }
      set
      {
        this.lockLevelField = value;
      }
    }

    [XmlIgnore]
    public bool LockLevelSpecified
    {
      get
      {
        return this.lockLevelFieldSpecified;
      }
      set
      {
        this.lockLevelFieldSpecified = value;
      }
    }

    [XmlElement(Order = 1)]
    public int FailedAuthenticationThreshold
    {
      get
      {
        return this.failedAuthenticationThresholdField;
      }
      set
      {
        this.failedAuthenticationThresholdField = value;
      }
    }

    [XmlIgnore]
    public bool FailedAuthenticationThresholdSpecified
    {
      get
      {
        return this.failedAuthenticationThresholdFieldSpecified;
      }
      set
      {
        this.failedAuthenticationThresholdFieldSpecified = value;
      }
    }

    [XmlElement(DataType = "duration", Order = 2)]
    public string LockDuration
    {
      get
      {
        return this.lockDurationField;
      }
      set
      {
        this.lockDurationField = value;
      }
    }
  }
}
