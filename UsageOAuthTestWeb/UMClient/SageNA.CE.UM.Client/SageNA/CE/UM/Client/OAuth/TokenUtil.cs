// Type: SageNA.CE.UM.Client.OAuth.TokenUtil
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using Sage.Obsidian.Shared.Schema;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace SageNA.CE.UM.Client.OAuth
{
  public static class TokenUtil
  {
    public static string ExtractBearerToken(out string errorMessage, HttpRequest httpRequest)
    {
      string str = TokenUtil.GetAuthorizationToken(httpRequest, out errorMessage);
      if (string.IsNullOrEmpty(errorMessage) && !string.IsNullOrEmpty(str))
      {
        if (str.StartsWith("Bearer "))
          str = str.Substring(7);
        else
          errorMessage = "Token invalid or missing";
      }
      return str;
    }

    public static AuthenticationToken BuildAuthenticationToken(string encryptionKey, string initialisationVector, X509Certificate2 sageIdRootCert, string authorizationToken, bool isTokenEncrypted, out string errorMessage)
    {
      byte[] clearTextToken;
      try
      {
        clearTextToken = !isTokenEncrypted ? Convert.FromBase64String(authorizationToken) : TokenDecryptionUtil.DecryptToken(encryptionKey, initialisationVector, Convert.FromBase64String(authorizationToken));
      }
      catch
      {
        errorMessage = "Error decrypting or decoding token";
        return (AuthenticationToken) null;
      }
      AuthenticationToken authenticationToken = TokenUtil.GetAuthenticationToken(sageIdRootCert, clearTextToken, out errorMessage, isTokenEncrypted);
      if (!string.IsNullOrEmpty(errorMessage))
        return (AuthenticationToken) null;
      else
        return authenticationToken;
    }

    private static string GetAuthorizationToken(HttpRequest currentRequest, out string errorMessage)
    {
      errorMessage = string.Empty;
      if (Enumerable.Contains<string>((IEnumerable<string>) currentRequest.Headers.AllKeys, "Authorization"))
        return currentRequest.Headers["Authorization"];
      if (currentRequest.HttpMethod == "GET")
      {
        errorMessage = "HTTP GET requests only support auth tokens in the Authorization header";
        return (string) null;
      }
      else if (currentRequest.ContentType != "application/x-www-form-urlencoded")
      {
        errorMessage = "Tokens in the request body can only be accepted when the ContentType is application/x-www-form-urlencoded";
        return (string) null;
      }
      else
      {
        NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(new StreamReader(currentRequest.InputStream).ReadToEnd());
        if (Enumerable.Contains<string>((IEnumerable<string>) nameValueCollection.AllKeys, "access_token"))
          return nameValueCollection["access_token"];
        errorMessage = "Access_token parameter missing from body";
        return (string) null;
      }
    }

    private static AuthenticationToken GetAuthenticationToken(X509Certificate2 sageIdRootCert, byte[] clearTextToken, out string errorMessage, bool IsTokenEncrypted)
    {
      errorMessage = string.Empty;
      XmlDocument notification = new XmlDocument();
      using (MemoryStream memoryStream = new MemoryStream(clearTextToken))
      {
        XmlReader reader = XmlReader.Create((Stream) memoryStream);
        notification.Load(reader);
      }
      if (IsTokenEncrypted)
      {
        try
        {
          TokenDecryptionUtil.CheckNotificationValidSignature(sageIdRootCert, notification);
        }
        catch (Exception ex)
        {
          errorMessage = "Problem with token signature. Exception: " + (object) ex;
          return (AuthenticationToken) null;
        }
      }
      using (MemoryStream memoryStream = new MemoryStream(clearTextToken))
      {
        try
        {
          memoryStream.Position = 0L;
          return new XmlSerializer(typeof (AuthenticationToken)).Deserialize((Stream) memoryStream) as AuthenticationToken;
        }
        catch (Exception ex)
        {
          errorMessage = "Deserialisation failed. Exception: " + (object) ex;
          return (AuthenticationToken) null;
        }
      }
    }
  }
}
