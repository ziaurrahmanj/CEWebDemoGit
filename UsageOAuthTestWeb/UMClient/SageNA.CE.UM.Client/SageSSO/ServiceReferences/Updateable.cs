// Type: SageSSO.ServiceReferences.Updateable
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
  [XmlInclude(typeof (UserIdentity))]
  [XmlInclude(typeof (WebApplication))]
  [XmlType(Namespace = "http://sso.sage.com")]
  [XmlInclude(typeof (MobileAuthorizationClient))]
  [XmlInclude(typeof (DesktopAuthorizationClient))]
  [XmlInclude(typeof (WebAuthorizationClient))]
  [XmlInclude(typeof (Profile))]
  [XmlInclude(typeof (UserAccountPolicy))]
  [XmlInclude(typeof (Identity))]
  [XmlInclude(typeof (SecretKeyIdentity))]
  [XmlInclude(typeof (X509Identity))]
  [XmlInclude(typeof (AuthorizationClient))]
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [DebuggerStepThrough]
  [Serializable]
  public class Updateable
  {
    private long versionStampField;
    private bool versionStampFieldSpecified;

    [XmlElement(Order = 0)]
    public long VersionStamp
    {
      get
      {
        return this.versionStampField;
      }
      set
      {
        this.versionStampField = value;
      }
    }

    [XmlIgnore]
    public bool VersionStampSpecified
    {
      get
      {
        return this.versionStampFieldSpecified;
      }
      set
      {
        this.versionStampFieldSpecified = value;
      }
    }
  }
}
