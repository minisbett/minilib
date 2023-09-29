using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Results;

/// <summary>
/// Represents the result of an operation, either successful or not (with an exception).
/// </summary>
public class Result
{
  /// <summary>
  /// Bool whether the operation was successful or not.
  /// </summary>
  public bool Successful => Exception is null;

  /// <summary>
  /// The exception of the operation or null if the operation was successful.
  /// </summary>
  public Exception? Exception { get; }

  /// <summary>
  /// Creates a new instance of <see cref="Result"/> with the specified exception of the operation.
  /// If the exception is null, the result is considered successful.
  /// </summary>
  /// <param name="exception"></param>
  internal Result(Exception? exception)
  {
    Exception = exception;
  }

  /// <summary>
  /// Returns a new instance of <see cref="Result"/> with no exception, indicating a successful operation.
  /// </summary>
  public static Result Success => new Result(null);

  /// <summary>
  /// Returns a new instance of <see cref="Result"/> with the specified exception, indicating a failed operation.
  /// </summary>
  /// <param name="exception">The exception of the operation.</param>
  public static Result Error(Exception exception)
  {
    ArgumentNullException.ThrowIfNull(exception, nameof(exception));

    return new Result(exception);
  }

  /// <summary>
  /// Implicitly converts the exception to an errored <see cref="Result"/>.
  /// </summary>
  /// <param name="exception">The exception.</param>
  public static implicit operator Result(Exception exception) => Error(exception);
}
