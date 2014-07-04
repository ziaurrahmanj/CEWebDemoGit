// Type: SageNA.CE.UM.Client.SSOState
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using CEDataService;
using SageNA.CE.UMClientInterface;
using System;

namespace SageNA.CE.UM.Client
{
  public class SSOState : ISSOState
  {
    public ReasonCode _SignOnFailureReason;
    public string _Message;

    public UserSignOnResult AuthInfo { get; set; }

    public Guid SignOnAttempt { get; set; }

    public Guid ExistingUserRegistrationAttempt { get; set; }

    public Guid NewUserRegistrationAttempt { get; set; }

    public Guid RegistrationProductUserId { get; set; }

    public object Result { get; set; }

    public ReasonCode SignOnFailureReason
    {
      get
      {
        return this._SignOnFailureReason;
      }
      set
      {
        this._SignOnFailureReason = value;
        if (this.AuthInfo == null)
          return;
        this.AuthInfo.Reason = value;
      }
    }

    public string Message
    {
      get
      {
        return this._Message;
      }
      set
      {
        this._Message = value;
        if (this.AuthInfo == null)
          return;
        this.AuthInfo.SignOnInfoText = this.Message;
      }
    }

    public SSOState()
    {
      this.AuthInfo = new UserSignOnResult()
      {
        IsValid = false,
        IsAuthoritative = false,
        OAuthReason = OAuthReasonCode.OAuthNA,
        Reason = ReasonCode.ProtocolViolation,
        OriginalRequestUrl = string.Empty,
        SignOnInfoText = string.Empty,
        User = (PersonAccessInfo) null
      };
      this.SignOnFailureReason = this.AuthInfo.Reason;
      this.Message = this.AuthInfo.SignOnInfoText;
      this.ExistingUserRegistrationAttempt = Guid.Empty;
      this.NewUserRegistrationAttempt = Guid.Empty;
      this.RegistrationProductUserId = Guid.Empty;
      this.Result = (object) null;
    }
  }
}
