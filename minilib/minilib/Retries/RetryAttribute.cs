using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Retries;

[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public sealed class RetryAttribute : Attribute
{
  // Purposefully do not make the properties assignable via the constructor to force the use of named arguments.
  
  /// <summary>
  /// The maximum amount of attempts to make.
  /// </summary>
  public required int Attempts { get; init; }

  /// <summary>
  /// The delay between each attempt in milliseconds.
  /// </summary>
  public required int Interval { get; init; }
}
