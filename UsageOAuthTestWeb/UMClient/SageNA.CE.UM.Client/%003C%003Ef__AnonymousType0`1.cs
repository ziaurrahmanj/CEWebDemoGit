// Type: <>f__AnonymousType0`1
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

[DebuggerDisplay("\\{ sessionEnded = {sessionEnded} }", Type = "<Anonymous Type>")]
[CompilerGenerated]
internal sealed class \u003C\u003Ef__AnonymousType0<\u003CsessionEnded\u003Ej__TPar>
{
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  private readonly \u003CsessionEnded\u003Ej__TPar \u003CsessionEnded\u003Ei__Field;

  public \u003CsessionEnded\u003Ej__TPar sessionEnded
  {
    get
    {
      return this.\u003CsessionEnded\u003Ei__Field;
    }
  }

  [DebuggerHidden]
  public \u003C\u003Ef__AnonymousType0(\u003CsessionEnded\u003Ej__TPar sessionEnded)
  {
    // ISSUE: reference to a compiler-generated field
    this.\u003CsessionEnded\u003Ei__Field = sessionEnded;
  }

  [DebuggerHidden]
  public override string ToString()
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append("{ sessionEnded = ");
    // ISSUE: reference to a compiler-generated field
    stringBuilder.Append((object) this.\u003CsessionEnded\u003Ei__Field);
    stringBuilder.Append(" }");
    return ((object) stringBuilder).ToString();
  }

  [DebuggerHidden]
  public override bool Equals(object value)
  {
    var fAnonymousType0 = value as \u003C\u003Ef__AnonymousType0<\u003CsessionEnded\u003Ej__TPar>;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return fAnonymousType0 != null && EqualityComparer<\u003CsessionEnded\u003Ej__TPar>.Default.Equals(this.\u003CsessionEnded\u003Ei__Field, fAnonymousType0.\u003CsessionEnded\u003Ei__Field);
  }

  [DebuggerHidden]
  public override int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated field
    return -1521134295 * 1547423462 + EqualityComparer<\u003CsessionEnded\u003Ej__TPar>.Default.GetHashCode(this.\u003CsessionEnded\u003Ei__Field);
  }
}
