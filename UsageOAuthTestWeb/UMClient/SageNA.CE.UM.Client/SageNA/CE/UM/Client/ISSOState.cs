// Type: SageNA.CE.UM.Client.ISSOState
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using SageNA.CE.UMClientInterface;
using System;

namespace SageNA.CE.UM.Client
{
  public interface ISSOState
  {
    UserSignOnResult AuthInfo { get; set; }

    ReasonCode SignOnFailureReason { get; set; }

    string Message { get; set; }

    Guid SignOnAttempt { get; set; }

    Guid ExistingUserRegistrationAttempt { get; set; }

    Guid NewUserRegistrationAttempt { get; set; }

    Guid RegistrationProductUserId { get; set; }

    object Result { get; set; }
  }
}
