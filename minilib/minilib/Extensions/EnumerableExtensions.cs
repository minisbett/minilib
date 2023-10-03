using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="IEnumerable{T}"/> class.
/// </summary>
public static class EnumerableExtensions
{
  /// <summary>
  /// Returns an <see cref="IEnumerable{int}"/> with the specified range and step size.
  /// </summary>
  /// <param name="min">The minimum value of the range.</param>
  /// <param name="max">The maximum value of the range.</param>
  /// <param name="steps">The step size of the range.</param>
  /// <returns>An <see cref="IEnumerable{int}"/> with the specified range.</returns>
  public static IEnumerable<int> To(this int min, int max, int steps = 1)
  {
    for (int i = min; i <= max; i += steps)
      yield return i;
  }

  /// <summary>
  /// Returns an <see cref="IEnumerable{long}"/> with the specified range and step size.
  /// </summary>
  /// <param name="min">The minimum value of the range.</param>
  /// <param name="max">The maximum value of the range.</param>
  /// <param name="steps">The step size of the range.</param>
  /// <returns>An <see cref="IEnumerable{long}"/> with the specified range.</returns>
  public static IEnumerable<long> To(this long min, long max, long steps = 1)
  {
    for (long i = min; i <= max; i += steps)
      yield return i;
  }

  /// <summary>
  /// Returns an <see cref="IEnumerable{float}"/> with the specified range and step size.
  /// </summary>
  /// <param name="min">The minimum value of the range.</param>
  /// <param name="max">The maximum value of the range.</param>
  /// <param name="steps">The step size of the range.</param>
  /// <returns>An <see cref="IEnumerable{float}"/> with the specified range.</returns>
  public static IEnumerable<float> To(this float min, float max, float steps = 1)
  {
    for (float i = min; i <= max; i += steps)
      yield return i;
  }

  /// <summary>
  /// Returns an <see cref="IEnumerable{double}"/> with the specified range and step size.
  /// </summary>
  /// <param name="min">The minimum value of the range.</param>
  /// <param name="max">The maximum value of the range.</param>
  /// <param name="steps">The step size of the range.</param>
  /// <returns>An <see cref="IEnumerable{double}"/> with the specified range.</returns>
  public static IEnumerable<double> To(this double min, double max, double steps = 1)
  {
    for (double i = min; i <= max; i += steps)
      yield return i;
  }

  /// <summary>
  /// Returns an <see cref="IEnumerable{T}"/> with every Xth element of the specified <see cref="IEnumerable{T}"/>.
  /// </summary>
  /// <typeparam name="T">The type.</typeparam>
  /// <param name="enumerable">The input enumerable.</param>
  /// <param name="steps">The step size.</param>
  /// <returns>An <see cref="IEnumerable{T}"/> with every Xth element of the input enumerable.</returns>
  public static IEnumerable<T> Steps<T>(this IEnumerable<T> enumerable, int steps)
  {
    int i = 0;

    foreach (T item in enumerable)
      if (i++ % steps == 0)
        yield return item;
  }

  /// <summary>
  /// Adds the specified values to the specified <see cref="IList{T}"/>.
  /// </summary>
  /// <typeparam name="T">The type.</typeparam>
  /// <param name="list">The input list.</param>
  /// <param name="values">The values to add to the list.</param>
  public static void AddRange<T>(this IList<T> list, params T[] values)
  {
    foreach (T value in values)
      list.Add(value);
  }

  /// <summary>
  /// Converts each element in the specified IEnumerable to a string and joins them with a comma-separator.
  /// e.g.: 1, 2, 3, 4, 5
  /// </summary>
  /// <typeparam name="T">The element type.</typeparam>
  /// <param name="enumerable">The enumerable to convert to a string.</param>
  /// <returns>A comma-separated string representation of all elements in the enumerable.</returns>
  public static string ToString<T>(this IEnumerable<T> enumerable) => string.Join(", ", enumerable);

  /// <summary>
  /// Converts each element in each sub-enumerable in the specified IEnumerable to a string and joins them with a comma-separator,
  /// grouped using parentheses.
  /// e.g.: (1, 2, 3), (4, 5, 6), (7, 8, 9)
  /// </summary>
  /// <typeparam name="T">The element type.</typeparam>
  /// <param name="enumerables">The enumerable to convert to a string.</param>
  /// <returns>A comma-separated string representation of all elements all sub-enumerables of the enumerable.</returns>
  public static string ToString<T>(this IEnumerable<IEnumerable<T>> enumerables)
  {
    // If no sub-enumerables exist, return an empty string since otherwise it'd return "()".
    if (!enumerables.Any())
      return "";

    return "(" + string.Join("), (", enumerables.Select(x => x.ToString<T>())) + ")";
  }

  /// <summary>
  /// Converts each element in each sub-enumerable of each sub-enumerable in the specified IEnumerable to a string and joins them,
  /// with a comma-separator, grouped by parantheses into groups which are grouped by brackets.
  /// [(1, 0), (0, 1)], [(0, 0), (1, 1)]
  /// </summary>
  /// <typeparam name="T">The element type.</typeparam>
  /// <param name="enumerables">The enumerable to convert to a string.</param>
  /// <returns>A comma-separated string representation of all elements all sub-enumerables of the enumerable.</returns>
  public static string ToString<T>(this IEnumerable<IEnumerable<IEnumerable<T>>> enumerables)
  {
    // If no sub-enumerables exist, return an empty string since otherwise it'd return "[]".
    if (!enumerables.Any())
      return "";
    
    return "[" + string.Join("], [", enumerables.Select(x => x.ToString<T>())) + "]";
  }
}
