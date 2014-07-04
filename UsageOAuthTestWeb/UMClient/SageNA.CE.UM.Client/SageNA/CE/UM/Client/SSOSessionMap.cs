// Type: SageNA.CE.UM.Client.SSOSessionMap
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System;
using System.Web;
using System.Web.Caching;

namespace SageNA.CE.UM.Client
{
  public class SSOSessionMap
  {
    public static TimeSpan DefaultSessionTimeout
    {
      get
      {
        return TimeSpan.FromMinutes((double) HttpContext.Current.Session.Timeout);
      }
    }

    public static void AddSSOSession(Guid ssoSessionId, DateTime ssoSessionExpiry, string applicationSessionId)
    {
      string cacheId = SSOSessionMap.MapEntry.GetCacheId(ssoSessionId);
      CacheManager.Instance.Remove(cacheId);
      CacheManager.Instance.Store(cacheId, (object) new SSOSessionMap.MapEntry()
      {
        SSOSessionId = ssoSessionId,
        ApplicationSessionId = applicationSessionId,
        ExtendOnUserActivity = false,
        LastActivity = DateTime.UtcNow,
        SSOSessionExpiry = ssoSessionExpiry
      }, ssoSessionExpiry);
    }

    public static bool ExtendSSOSession(Guid ssoSessionId, DateTime ssoSessionExpiry)
    {
      string cacheId = SSOSessionMap.MapEntry.GetCacheId(ssoSessionId);
      object retVal;
      CacheManager.Instance.Load(cacheId, out retVal);
      if (retVal == null)
        return false;
      SSOSessionMap.MapEntry mapEntry = (SSOSessionMap.MapEntry) retVal;
      mapEntry.SSOSessionExpiry = ssoSessionExpiry;
      CacheManager.Instance.Store(cacheId, (object) mapEntry, ssoSessionExpiry);
      return true;
    }

    public static void EndSSOSession(Guid ssoSessionId)
    {
      CacheManager.Instance.Remove(SSOSessionMap.MapEntry.GetCacheId(ssoSessionId));
    }

    public static DateTime GetSSOSessionExpiry(Guid ssoSessionId)
    {
      SSOSessionMap.MapEntry mapEntry = (SSOSessionMap.MapEntry) HttpContext.Current.Cache.Get(SSOSessionMap.MapEntry.GetCacheId(ssoSessionId));
      if (mapEntry != null)
        return mapEntry.SSOSessionExpiry;
      else
        throw new Exception("No SSO session with specified ID in the cache.");
    }

    public static bool HasSSOSession(Guid ssoSessionId)
    {
      object retVal;
      CacheManager.Instance.Load(SSOSessionMap.MapEntry.GetCacheId(ssoSessionId), out retVal);
      return retVal != null;
    }

    public static void RefreshSSOSession(Guid ssoSessionId)
    {
      string cacheId = SSOSessionMap.MapEntry.GetCacheId(ssoSessionId);
      object retVal;
      CacheManager.Instance.Load(cacheId, out retVal);
      if (retVal == null)
        throw new Exception("No SSO session with specified ID in the cache.");
      SSOSessionMap.MapEntry mapEntry = (SSOSessionMap.MapEntry) retVal;
      mapEntry.LastActivity = DateTime.UtcNow;
      CacheManager.Instance.Remove(cacheId);
      CacheManager.Instance.Store(cacheId, (object) mapEntry, mapEntry.SSOSessionExpiry);
    }

    public static bool ShouldExtendSSOSession(Guid ssoSessionId, DateTime ssoSessionExpiryDue, out DateTime newSSOSessionExpiry)
    {
      object retVal;
      CacheManager.Instance.Load(SSOSessionMap.MapEntry.GetCacheId(ssoSessionId), out retVal);
      if (retVal == null)
        throw new Exception("No SSO session with specified ID in the cache.");
      SSOSessionMap.MapEntry mapEntry = (SSOSessionMap.MapEntry) retVal;
      newSSOSessionExpiry = mapEntry.LastActivity + SSOSessionMap.DefaultSessionTimeout;
      return newSSOSessionExpiry > ssoSessionExpiryDue;
    }

    public static bool ShouldExtendSSOSessionOnUserActivity(Guid ssoSessionId)
    {
      object retVal;
      CacheManager.Instance.Load(SSOSessionMap.MapEntry.GetCacheId(ssoSessionId), out retVal);
      if (retVal != null)
        return ((SSOSessionMap.MapEntry) retVal).ExtendOnUserActivity;
      else
        return false;
    }

    public static void SetShouldExtendSSOSessionOnUserActivity(Guid ssoSessionId, bool expiryDue)
    {
      string cacheId = SSOSessionMap.MapEntry.GetCacheId(ssoSessionId);
      object retVal;
      CacheManager.Instance.Load(cacheId, out retVal);
      if (retVal == null)
        throw new Exception("No SSO session with specified ID in the cache.");
      SSOSessionMap.MapEntry mapEntry = (SSOSessionMap.MapEntry) retVal;
      mapEntry.ExtendOnUserActivity = expiryDue;
      HttpContext.Current.Cache.Insert(cacheId, (object) mapEntry, (CacheDependency) null, mapEntry.SSOSessionExpiry, Cache.NoSlidingExpiration, CacheItemPriority.Normal, (CacheItemRemovedCallback) null);
    }

    [Serializable]
    private class MapEntry
    {
      private const string CachedIdFormat = "SSOSessionId_{0}";

      internal Guid SSOSessionId { get; set; }

      internal string ApplicationSessionId { get; set; }

      internal DateTime SSOSessionExpiry { get; set; }

      internal bool ExtendOnUserActivity { get; set; }

      internal DateTime LastActivity { get; set; }

      internal static string GetCacheId(Guid ssoSessionId)
      {
        return string.Format("SSOSessionId_{0}", (object) ssoSessionId.ToString());
      }
    }
  }
}
