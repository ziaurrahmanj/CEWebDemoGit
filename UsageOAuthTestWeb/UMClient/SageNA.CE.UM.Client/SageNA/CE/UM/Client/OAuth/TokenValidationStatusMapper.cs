// Type: SageNA.CE.UM.Client.OAuth.TokenValidationStatusMapper
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using SageNA.CE.UMClientInterface;
using System.Collections.Generic;

namespace SageNA.CE.UM.Client.OAuth
{
  public static class TokenValidationStatusMapper
  {
    public static Dictionary<TokenValidationStatus, OAuthReasonCode> _TokenValidationStatusMap = new Dictionary<TokenValidationStatus, OAuthReasonCode>()
    {
      {
        TokenValidationStatus.Success,
        OAuthReasonCode.OAuthOK
      },
      {
        TokenValidationStatus.FailUnknownError,
        OAuthReasonCode.OAuthBadRequest
      },
      {
        TokenValidationStatus.FailNoBearerToken,
        OAuthReasonCode.OAuthUnauthorized
      },
      {
        TokenValidationStatus.FailTokenHeader,
        OAuthReasonCode.OAuthUnauthorized
      },
      {
        TokenValidationStatus.FailTokenSchema,
        OAuthReasonCode.OAuthBadRequest
      },
      {
        TokenValidationStatus.FailTokenDecryption,
        OAuthReasonCode.OAuthUnauthorized
      },
      {
        TokenValidationStatus.FailTokenDeserialize,
        OAuthReasonCode.OAuthUnauthorized
      },
      {
        TokenValidationStatus.FailUserPrincipal,
        OAuthReasonCode.OAuthBadRequest
      },
      {
        TokenValidationStatus.FailSecretkeyPrincipal,
        OAuthReasonCode.OAuthBadRequest
      },
      {
        TokenValidationStatus.FailTokenNotYetValid,
        OAuthReasonCode.OAuthBadRequest
      },
      {
        TokenValidationStatus.FailTokenExpired,
        OAuthReasonCode.OAuthUnauthorized
      },
      {
        TokenValidationStatus.FailNoResourceAccess,
        OAuthReasonCode.OAuthForbidden
      }
    };

    static TokenValidationStatusMapper()
    {
    }

    public static OAuthReasonCode ValidationStatusToReasonCode(TokenValidationStatus status)
    {
      return TokenValidationStatusMapper._TokenValidationStatusMap.ContainsKey(status) ? TokenValidationStatusMapper._TokenValidationStatusMap[status] : OAuthReasonCode.OAuthInternalError;
    }
  }
}
