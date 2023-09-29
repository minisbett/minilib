using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Results;

/// <summary>
/// Represents the result of an operation, either successful with a value or not (with an exception).
/// </summary>
/// <typeparam name="T"></typeparam>
public class Result<T> : Result where T : class
{
  /// <summary>
  /// The return value of the operation.
  /// </summary>
  public T? Value { get; }

  /// <summary>
  /// Creates a new instance of <see cref="Result{T}"/> with the specified value and exception.
  /// </summary>
  /// <param name="value">The return value.</param>
  /// <param name="exception">The exception of the operation or null if the operation was successful.</param>
  private Result(T? value, Exception? exception) : base(exception)
  {
    Value = value;
  }

  /// <summary>
  /// Returns a new instance of <see cref="Result{T}"/> with the specified value and no exception, indicating a successful operation.
  /// </summary>
  public static new Result<T> Success(T? value) => new Result<T>(value, null);

  /// <summary>
  /// Returns a new instance of <see cref="Result{T}"/> with the specified exception, indicating a failed operation.
  /// </summary>
  /// <param name="exception">The exception of the operation.</param>
  public static new Result<T> Error(Exception exception)
  {
    ArgumentNullException.ThrowIfNull(exception, nameof(exception));

    return new Result<T>(null, exception);
  }

  /// <summary>
  /// Implicitly converts the value to a successful <see cref="Result{T}"/>.
  /// </summary>
  /// <param name="value">The value.</param>
  public static implicit operator Result<T>(T? value) => Success(value);

  /// <summary>
  /// Implicitly converts the exception to an errored <see cref="Result{T}"/>.
  /// </summary>
  /// <param name="exception">The exception.</param>
  public static implicit operator Result<T>(Exception exception) => Error(exception);
}