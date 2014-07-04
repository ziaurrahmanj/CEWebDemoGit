// Type: SageNA.CE.UM.Client.OAuth.TokenValidationStatus
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

namespace SageNA.CE.UM.Client.OAuth
{
  public enum TokenValidationStatus
  {
    Success,
    FailUnknownError,
    FailNoBearerToken,
    FailTokenHeader,
    FailTokenSchema,
    FailTokenDecryption,
    FailTokenDeserialize,
    FailUserPrincipal,
    FailSecretkeyPrincipal,
    FailTokenNotYetValid,
    FailTokenExpired,
    FailNoResourceAccess,
  }
}
