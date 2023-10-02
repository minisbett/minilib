using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.DependencyInjection;

/// <summary>
/// Attribute for marking fields that objects should be injected into.
/// </summary>
[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
public class InjectAttribute : Attribute
{
  /// <summary>
  /// An optional identifier to differentiate between multiple instances of the same type.
  /// If this is specified, only injectables with the same type and identifier will be injected.
  /// </summary>
  public string? Identifier { get; }

  /// <summary>
  /// Allows to specify a container to accept an injection from. This must match the identifier of the container.
  /// </summary>
  public string? Container { get; init; }


  /// <summary>
  /// Marks fields as injectable, optionally using the specified identifier to differentiate between multiple injectables of the same type.
  /// </summary>
  /// <param name="identifier">
  /// An optional identifier to differentiate between multiple instances of the same type.
  /// If this is specified, only injectables with the same type and identifier will be injected.
  /// </param>
  public InjectAttribute(string? identifier = null)
  {
    Identifier = identifier;
  }
}