using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Extensions;

/// <summary>
/// Provides extension methods for creating instances of the <see cref="TimeSpan"/> class.
/// </summary>
public static class TimeSpanExtensions
{
  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of milliseconds.
  /// </summary>
  /// <param name="milliseconds">The milliseconds of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of milliseconds.</returns>
  public static TimeSpan Milliseconds(this int milliseconds)
  {
    return TimeSpan.FromMilliseconds(milliseconds);
  }

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of seconds.
  /// </summary>
  /// <param name="seconds">The seconds of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of seconds.</returns>
  public static TimeSpan Seconds(this int seconds)
  {
    return TimeSpan.FromSeconds(seconds);
  }

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of minutes.
  /// </summary>
  /// <param name="minutes">The minutes of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of minutes.</returns>
  public static TimeSpan Minutes(this int minutes)
  {
    return TimeSpan.FromMinutes(minutes);
  }

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of hours.
  /// </summary>
  /// <param name="hours">The hours of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of hours.</returns>
  public static TimeSpan Hours(this int hours)
  {
    return TimeSpan.FromHours(hours);
  }

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of days.
  /// </summary>
  /// <param name="days">The days of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of days.</returns>
  public static TimeSpan Days(this int days)
  {
    return TimeSpan.FromDays(days);
  }
}
