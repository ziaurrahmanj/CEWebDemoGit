// Type: SageNA.CE.UM.Client.UriHelper
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using SageNA.CE.UMClientInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SageNA.CE.UM.Client
{
  internal static class UriHelper
  {
    internal static Uri ToAbsoluteUri(AppConfig _AppConfig, HttpContextBase httpContext, string targetPath)
    {
      Uri baseUri;
      if (_AppConfig.AppBaseUri.Length > 1)
      {
        baseUri = new Uri(_AppConfig.AppBaseUri);
      }
      else
      {
        UriBuilder uriBuilder = new UriBuilder();
        uriBuilder.Scheme = httpContext.Request.Url.Scheme;
        string str = httpContext.Request.Params["HTTP_HOST"];
        if (str != null && str.Length > 1)
        {
          string[] strArray = str.Split(new char[1]
          {
            ':'
          });
          uriBuilder.Host = strArray[0];
          int result;
          if (Enumerable.Count<string>((IEnumerable<string>) strArray) > 1 && int.TryParse(strArray[1], out result))
            uriBuilder.Port = result;
        }
        else
        {
          uriBuilder.Host = httpContext.Request.Url.Host;
          uriBuilder.Port = httpContext.Request.Url.Port;
        }
        baseUri = uriBuilder.Uri;
      }
      return new Uri(baseUri, targetPath);
    }
  }
}
