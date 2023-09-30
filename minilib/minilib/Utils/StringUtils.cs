using minilib.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Utils;

/// <summary>
/// Provides utility methods for strings.
/// </summary>
public static class StringUtils
{
  /// <summary>
  /// Static random instance since creating a new instance everytime is unecessary.
  /// </summary>
  private static readonly Random _random = new Random();

  /// <summary>
  /// Generates a random string of the specified length and character set.
  /// If no character set is specified, all printable ASCII characters (32-126) are used.
  /// </summary>
  /// <param name="length">The length of the randomly generated string.</param>
  /// <param name="charSet">The character set to randomly pick characters for the string from.</param>
  /// <returns></returns>
  public static string Random(int length, char[]? charSet = null)
  {
    // Default to all printable ASCII characters.
    charSet ??= StringConstants.PRINTABLE_ASCII;
    string str = "";

    // Generate the string character by character and return it.
    for (int i = 0; i < length; i++)
      str += charSet[_random.Next(charSet.Length)];
    return str;
  }
}
