using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Extensions;

/// <summary>
/// Provides extension methods for creating instances of the <see cref="object"/> class, as well as other generic types. 
/// </summary>
public static class ObjectExtensions
{
  /// <summary>
  /// Casts the specified object to the specified type using <see cref="Convert.ChangeType(object, Type)"/>.
  /// </summary>
  /// <typeparam name="T">The type.</typeparam>
  /// <param name="o">The object.</param>
  /// <returns>The casted object.</returns>
  public static T As<T>(this object o)
  {
    return (T)Convert.ChangeType(o, typeof(T));
  }

  /// <summary>
  /// Tries to cast the specified object to the specified type using <see cref="Convert.ChangeType(object, Type)"/>.
  /// If casting fails, the default value of the type is returned instead.
  /// </summary>
  /// <typeparam name="T">The type.</typeparam>
  /// <param name="obj">The object.</param>
  /// <returns>The casted object, or the type's default value if casting failed.</returns>
  public static T? AsOrDefault<T>(this object obj)
  {
    try { return As<T>(obj); }
    catch { return default; }
  }
}
