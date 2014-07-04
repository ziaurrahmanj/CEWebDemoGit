// Type: <>f__AnonymousType3`3
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

[DebuggerDisplay("\\{ controller = {controller}, action = {action}, emailReference = {emailReference} }", Type = "<Anonymous Type>")]
[CompilerGenerated]
internal sealed class \u003C\u003Ef__AnonymousType3<\u003Ccontroller\u003Ej__TPar, \u003Caction\u003Ej__TPar, \u003CemailReference\u003Ej__TPar>
{
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  private readonly \u003Ccontroller\u003Ej__TPar \u003Ccontroller\u003Ei__Field;
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  private readonly \u003Caction\u003Ej__TPar \u003Caction\u003Ei__Field;
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  private readonly \u003CemailReference\u003Ej__TPar \u003CemailReference\u003Ei__Field;

  public \u003Ccontroller\u003Ej__TPar controller
  {
    get
    {
      return this.\u003Ccontroller\u003Ei__Field;
    }
  }

  public \u003Caction\u003Ej__TPar action
  {
    get
    {
      return this.\u003Caction\u003Ei__Field;
    }
  }

  public \u003CemailReference\u003Ej__TPar emailReference
  {
    get
    {
      return this.\u003CemailReference\u003Ei__Field;
    }
  }

  [DebuggerHidden]
  public \u003C\u003Ef__AnonymousType3(\u003Ccontroller\u003Ej__TPar controller, \u003Caction\u003Ej__TPar action, \u003CemailReference\u003Ej__TPar emailReference)
  {
    // ISSUE: reference to a compiler-generated field
    this.\u003Ccontroller\u003Ei__Field = controller;
    // ISSUE: reference to a compiler-generated field
    this.\u003Caction\u003Ei__Field = action;
    // ISSUE: reference to a compiler-generated field
    this.\u003CemailReference\u003Ei__Field = emailReference;
  }

  [DebuggerHidden]
  public override string ToString()
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append("{ controller = ");
    // ISSUE: reference to a compiler-generated field
    stringBuilder.Append((object) this.\u003Ccontroller\u003Ei__Field);
    stringBuilder.Append(", action = ");
    // ISSUE: reference to a compiler-generated field
    stringBuilder.Append((object) this.\u003Caction\u003Ei__Field);
    stringBuilder.Append(", emailReference = ");
    // ISSUE: reference to a compiler-generated field
    stringBuilder.Append((object) this.\u003CemailReference\u003Ei__Field);
    stringBuilder.Append(" }");
    return ((object) stringBuilder).ToString();
  }

  [DebuggerHidden]
  public override bool Equals(object value)
  {
    var fAnonymousType3 = value as \u003C\u003Ef__AnonymousType3<\u003Ccontroller\u003Ej__TPar, \u003Caction\u003Ej__TPar, \u003CemailReference\u003Ej__TPar>;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return fAnonymousType3 != null && EqualityComparer<\u003Ccontroller\u003Ej__TPar>.Default.Equals(this.\u003Ccontroller\u003Ei__Field, fAnonymousType3.\u003Ccontroller\u003Ei__Field) && EqualityComparer<\u003Caction\u003Ej__TPar>.Default.Equals(this.\u003Caction\u003Ei__Field, fAnonymousType3.\u003Caction\u003Ei__Field) && EqualityComparer<\u003CemailReference\u003Ej__TPar>.Default.Equals(this.\u003CemailReference\u003Ei__Field, fAnonymousType3.\u003CemailReference\u003Ei__Field);
  }

  [DebuggerHidden]
  public override int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return -1521134295 * (-1521134295 * (-1521134295 * -1236124662 + EqualityComparer<\u003Ccontroller\u003Ej__TPar>.Default.GetHashCode(this.\u003Ccontroller\u003Ei__Field)) + EqualityComparer<\u003Caction\u003Ej__TPar>.Default.GetHashCode(this.\u003Caction\u003Ei__Field)) + EqualityComparer<\u003CemailReference\u003Ej__TPar>.Default.GetHashCode(this.\u003CemailReference\u003Ei__Field);
  }
}
