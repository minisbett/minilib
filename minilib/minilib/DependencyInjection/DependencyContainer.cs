using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace minilib.DependencyInjection;

/// <summary>
/// Container for registering dependencies and injecting them into any object instance.
/// </summary>
public class DependencyContainer
{
  /// <summary>
  /// List of all injectables registered in this container.
  /// </summary>
  private List<Injectable> _injectables = new List<Injectable>();

  /// <summary>
  /// A unique identifier for this container for container constraints on injections.
  /// This can be done by specifying this identifier in the <seealso cref="InjectAttribute.Container"/> property.
  /// </summary>
  private string? _identifier = null;

  /// <summary>
  /// Creates a new instance of <seealso cref="DependencyContainer"/> and registers itself as an injectable for easy access.
  /// </summary>
  /// <param name="identifier">A string uniquely identifying this container for container constraints on injections.</param>
  public DependencyContainer(string? identifier = null)
  {
    _identifier = identifier;

    _injectables.Add(new Injectable(this, typeof(DependencyContainer), null));
  }

  /// <summary>
  /// Adds the specified object with it's type as is to the container. To register the object with a parent type, use the generic parameter.
  /// If multiple objects of the same type are registered, use the identifier parameter to differentiate between them.
  /// </summary>
  /// <typeparam name="T">The type the injectable is cached as.</typeparam>
  /// <param name="obj">The injectable object.</param>
  /// <param name="identifier">A string uniquely identifying this injectable from all other type-equal.</param>
  public void Register<T>(T obj, string? identifier = null)
  {
    ArgumentNullException.ThrowIfNull(obj, nameof(obj));

    // Check whether the injectable is already registered.
    if (_injectables.Any(x => x.Object.Equals(obj)))
      throw new ArgumentException("The injectable is already registered.");

    // Check whether there is already an injectable with the same type but no identifier has been specified.
    if (_injectables.Any(x => x.Type == typeof(T) && string.IsNullOrEmpty(identifier)))
      throw new ArgumentException("There is already an injectable with the same type but no identifier has been specified. " +
                                 $"Please specify an identifier to differentiate between the instances of type {typeof(T)}.");

    // Check whether there is already an injectable with the same type and identifier.
    if (_injectables.Any(x => x.Type == typeof(T) && x.Identifier == identifier))
      throw new ArgumentException("There is already an injectable with the same type and identifier." +
                                 $"Please choose a unique identifier to differentiate between the instances of type {typeof(T)}.");

    // Create a new injectable and add it to the list of injectables.
    _injectables.Add(new Injectable(obj, typeof(T), identifier));
  }

  /// <summary>
  /// Injects all dependencies known to this container into the specified object.
  /// </summary>
  /// <param name="obj">The object to inject the dependencies into.</param>
  public void Inject(object obj)
  {
    // Keep track of all injected injectables to notify the developer if an injectable is being injected multiple times.
    List<Injectable> injected = new List<Injectable>();

    // Iterate over all fields and inject the dependencies if the field has an [Inject] attribute.
    foreach (FieldInfo field in obj.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
    {
      // Get the [Inject] attribute of the field and continue if none is present.
      InjectAttribute? attrib = field.GetCustomAttribute<InjectAttribute>();
      if (attrib == null)
        continue;

      // Check whether a specific container is targetted by the [Inject] attribute
      // and continue if this is the case but the identifier does not match.
      if (attrib.Container is not null && attrib.Container != _identifier)
        continue;

      // Get the injectable that matches the field's type and identifier.
      Injectable? injectable = _injectables.FirstOrDefault(x => x.Type == field.FieldType &&
                                                                x.Identifier == attrib.Identifier);

      // Continue with the next field if no injectable was found.
      // This is not an error since the injectable might be registered in a different container.
      if (injectable == null)
        continue;

      // Check whether the injectable has already been injected. If so, throw an exception since this is a developer mistake.
      if (injected.Contains(injectable))
        throw new InvalidOperationException($"The injectable of type {field.FieldType} with identifier '{attrib.Identifier}' has already been injected.");

      // Set the field's value to the injectable's object and add the injectable to the list of injected injectables.
      field.SetValue(obj, injectable.Object);
      injected.Add(injectable);
    }
  }
}
