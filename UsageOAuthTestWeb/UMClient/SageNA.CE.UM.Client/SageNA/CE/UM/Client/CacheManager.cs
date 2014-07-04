// Type: SageNA.CE.UM.Client.CacheManager
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using Microsoft.ApplicationServer.Caching;
using Microsoft.WindowsAzure.ServiceRuntime;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SageNA.CE.UM.Client
{
  public class CacheManager
  {
    private static CacheManager _CacheManagerInstance = (CacheManager) null;
    private static Dictionary<string, object> _LocalCache = (Dictionary<string, object>) null;
    private static SortedList<DateTime, string> _LocalCacheExpiration = (SortedList<DateTime, string>) null;
    private static SortedList<string, DateTime> _LocalCacheExpirationTime = (SortedList<string, DateTime>) null;
    private DataCache _Cache = (DataCache) null;

    public static CacheManager Instance
    {
      get
      {
        if (CacheManager._CacheManagerInstance == null)
          CacheManager._CacheManagerInstance = new CacheManager();
        return CacheManager._CacheManagerInstance;
      }
    }

    public bool IsActive
    {
      get
      {
        return this._Cache != null || CacheManager._LocalCache != null;
      }
    }

    static CacheManager()
    {
    }

    private CacheManager()
    {
      bool flag = RoleEnvironment.IsAvailable;
      if (flag)
      {
        try
        {
          this._Cache = new DataCacheFactory().GetDefaultCache();
        }
        catch
        {
          flag = false;
        }
      }
      if (flag)
        return;
      this._Cache = (DataCache) null;
      CacheManager.ResetLocalCache();
    }

    public static void Reset()
    {
      CacheManager._CacheManagerInstance = (CacheManager) null;
    }

    public void Store(string key, object value, DateTime expirationTime)
    {
      if (!this.IsActive)
        return;
      if (this._Cache != null)
        this._Cache.Put(key, value, expirationTime.Subtract(DateTime.Now));
      else
        CacheManager.AddEntryToLocalCache(key, value, expirationTime);
    }

    public bool Load(string key, out object retVal)
    {
      bool success = false;
      retVal = (object) null;
      if (this.IsActive)
      {
        if (this._Cache != null)
        {
          try
          {
            retVal = this._Cache.Get(key);
            success = true;
          }
          catch
          {
            retVal = (object) null;
            success = false;
          }
        }
        else
          CacheManager.GetEntryFromLocalCache(key, ref retVal, ref success);
      }
      return success;
    }

    public bool Remove(string key)
    {
      bool flag = false;
      if (this.IsActive)
      {
        if (this._Cache != null)
        {
          try
          {
            flag = this._Cache.Remove(key);
          }
          catch
          {
            flag = false;
          }
        }
        else
          flag = CacheManager.RemoveEntryFromLocalCache(key);
      }
      return flag;
    }

    private static void AddEntryToLocalCache(string key, object value, DateTime exp)
    {
      lock (CacheManager._LocalCache)
      {
        lock (CacheManager._LocalCacheExpiration)
        {
          lock (CacheManager._LocalCacheExpirationTime)
          {
            CacheManager.ExpireCache();
            CacheManager._LocalCache[key] = value;
            bool local_0 = false;
            while (!local_0)
            {
              try
              {
                CacheManager._LocalCacheExpiration[exp] = key;
                local_0 = true;
              }
              catch (ArgumentException exception_0)
              {
                exp = exp.AddMilliseconds(1.0);
              }
            }
            CacheManager._LocalCacheExpiration[exp] = key;
            CacheManager._LocalCacheExpirationTime[key] = exp;
          }
        }
      }
    }

    private static void GetEntryFromLocalCache(string key, ref object retVal, ref bool success)
    {
      DateTime now = DateTime.Now;
      success = CacheManager._LocalCache.ContainsKey(key) && CacheManager._LocalCacheExpirationTime[key] > now;
      if (success)
        retVal = CacheManager._LocalCache[key];
      else
        retVal = (object) null;
    }

    private static bool RemoveEntryFromLocalCache(string key)
    {
      bool flag = CacheManager._LocalCache.ContainsKey(key);
      if (flag)
        CacheManager._LocalCache.Remove(key);
      return flag;
    }

    private static void ExpireCache()
    {
      DateTime now = DateTime.Now;
      while (true)
      {
        KeyValuePair<DateTime, string> keyValuePair;
        int num;
        if (Enumerable.Count<KeyValuePair<string, object>>((IEnumerable<KeyValuePair<string, object>>) CacheManager._LocalCache) > 0)
        {
          keyValuePair = Enumerable.First<KeyValuePair<DateTime, string>>((IEnumerable<KeyValuePair<DateTime, string>>) CacheManager._LocalCacheExpiration);
          num = keyValuePair.Key > now ? 1 : 0;
        }
        else
          num = 0;
        if (num != 0)
        {
          keyValuePair = Enumerable.First<KeyValuePair<DateTime, string>>((IEnumerable<KeyValuePair<DateTime, string>>) CacheManager._LocalCacheExpiration);
          string key = keyValuePair.Value;
          CacheManager._LocalCache.Remove(key);
          CacheManager._LocalCacheExpirationTime.Remove(key);
          CacheManager._LocalCacheExpiration.RemoveAt(0);
        }
        else
          break;
      }
    }

    private static void ResetLocalCache()
    {
      CacheManager._LocalCache = new Dictionary<string, object>();
      CacheManager._LocalCacheExpiration = new SortedList<DateTime, string>();
      CacheManager._LocalCacheExpirationTime = new SortedList<string, DateTime>();
    }
  }
}
