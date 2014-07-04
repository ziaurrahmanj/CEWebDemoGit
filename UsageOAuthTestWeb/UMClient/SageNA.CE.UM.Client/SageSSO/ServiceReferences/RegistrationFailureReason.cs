// Type: SageSSO.ServiceReferences.RegistrationFailureReason
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace SageSSO.ServiceReferences
{
  [XmlType(Namespace = "http://sso.sage.com")]
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [Serializable]
  public enum RegistrationFailureReason
  {
    ProtocolViolation,
    RegistrationCancelled,
    SessionExpired,
    SignOnFailed,
    RegistrationAttemptNotFound,
    AccountAlreadyRegistered,
    UnexpectedUserAccount,
  }
}
