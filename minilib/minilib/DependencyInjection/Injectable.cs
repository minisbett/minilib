using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.DependencyInjection;

/// <summary>
/// Represents an injectable object with it's instance and optionally identifier.
/// </summary>
internal class Injectable
{
  /// <summary>
  /// The injectable instance of the type.
  /// </summary>
  public object Object { get; }

  /// <summary>
  /// The type of the injectable object. This is the type specified on registration, not the actual type of the object.
  /// In cases where you want to inject a parent type, this is necessary to get the correct type.
  /// </summary>
  public Type Type { get; }

  /// <summary>
  /// An optional identifier to differentiate between multiple injectables of the same type.
  /// This is necessary to know which injectable is supposed to be injected into the field.
  /// </summary>
  public string? Identifier { get; }

  /// <summary>
  /// Creates a new instance of <see cref="Injectable"/> with the specified instance, type and identifier.
  /// </summary>
  /// <param name="instance">The injectable instance of the type.</param>
  /// <param name="type">The type of the injectable object.</param>
  /// <param name="identifier">An optional identifier to differentiate between multiple injectables of the same type.</param>
  public Injectable(object instance, Type type, string? identifier)
  {
    Object = instance;
    Type = type;
    Identifier = identifier;
  }
}
