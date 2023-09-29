using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Extensions;

/// <summary>
/// Provides extension methods for creating instances of the <see cref="string"/> class.
/// </summary>
public static class StringExtensions
{
  /// <summary>
  /// Provides a call to <see cref="string.Format(string, object[])"/> with a params string[] parameter.
  /// </summary>
  /// <param name="foramt">The string format.</param>
  /// <param name="args">The arguments for the formatted string.</param>
  /// <returns>The formatted string.</returns>
  public static string Format(this string format, params string[] args) => string.Format(format, args);
}
