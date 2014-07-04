// Type: SageNA.CE.UM.Client.TraceHelper
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Mvc;

namespace SageNA.CE.UM.Client
{
  public static class TraceHelper
  {
    private const string _SSOSessionTraceIndex = "SSOSessionTraceIndex";

    public static void TraceLog(this Controller controller, string message, params object[] parameters)
    {
      if (!true)
        return;
      try
      {
        TraceHelper.Append(controller, string.Format("{0:O} [{1}]: {2} - [{3}]", (object) DateTime.Now, (object) controller.Request.Url.ToString(), (object) message, (object) TraceHelper.SerializeParameters(parameters)));
      }
      catch
      {
        TraceHelper.Append(controller, string.Format("{0:O} [{1}]: {2}", (object) DateTime.Now, (object) "?", (object) message));
      }
    }

    public static string TraceLogOutput(this Controller controller)
    {
      object obj = controller.Session["SSOSessionTraceIndex"];
      return obj == null || !(obj is string) ? string.Empty : (string) obj;
    }

    private static void Append(Controller controller, string message)
    {
      object obj = controller.Session["SSOSessionTraceIndex"];
      string str = obj == null || !(obj is string) ? string.Empty : (string) obj;
      controller.Session["SSOSessionTraceIndex"] = (object) (str + "\r\n" + message);
      Debug.WriteLine(message);
    }

    private static string SerializeParameters(object[] parameters)
    {
      StringBuilder stringBuilder = new StringBuilder();
      bool flag = true;
      foreach (object par in parameters)
      {
        if (flag)
          flag = false;
        else
          stringBuilder.Append(", ");
        stringBuilder.Append(TraceHelper.DisplaySerialize(par));
      }
      return ((object) stringBuilder).ToString();
    }

    private static string DisplaySerialize(object par)
    {
      string str1;
      if (par == null)
      {
        str1 = "null";
      }
      else
      {
        string str2;
        try
        {
          using (MemoryStream memoryStream = new MemoryStream())
          {
            new DataContractJsonSerializer(par.GetType()).WriteObject((Stream) memoryStream, par);
            memoryStream.Position = 1L;
            using (StreamReader streamReader = new StreamReader((Stream) memoryStream))
              str2 = streamReader.ReadToEnd();
          }
        }
        catch
        {
          return par.ToString();
        }
        str1 = string.Format(" ({0}) {1}", (object) par.GetType().ToString(), (object) str2);
      }
      return str1;
    }
  }
}
