// Type: SageNA.CE.UM.Client.FormatHelper
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

namespace SageNA.CE.UM.Client
{
  public static class FormatHelper
  {
    public static string StructuredToCompoundName(string first, string middle, string last)
    {
      string str1 = FormatHelper.Normalize(first);
      string str2 = FormatHelper.Normalize(middle);
      string str3 = FormatHelper.Normalize(last);
      return string.Format("{0}{1}{2} {3}", (object) str1, str2.Length > 0 ? (object) " " : (object) string.Empty, (object) str2, (object) str3);
    }

    public static string Normalize(string input)
    {
      return input != null ? input.Trim() : string.Empty;
    }
  }
}
