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
  public static TimeSpan Milliseconds(this int milliseconds) => Milliseconds((double)milliseconds);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of milliseconds.
  /// </summary>
  /// <param name="milliseconds">The milliseconds of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of milliseconds.</returns>
  public static TimeSpan Milliseconds(this long milliseconds) => Milliseconds((double)milliseconds);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of milliseconds.
  /// </summary>
  /// <param name="milliseconds">The milliseconds of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of milliseconds.</returns>
  public static TimeSpan Milliseconds(this float milliseconds) => Milliseconds((double)milliseconds);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of milliseconds.
  /// </summary>
  /// <param name="milliseconds">The milliseconds of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of milliseconds.</returns>
  public static TimeSpan Milliseconds(this double milliseconds) => TimeSpan.FromMilliseconds(milliseconds);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of seconds.
  /// </summary>
  /// <param name="seconds">The seconds of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of seconds.</returns>
  public static TimeSpan Seconds(this int seconds) => Seconds((double)seconds);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of seconds.
  /// </summary>
  /// <param name="seconds">The seconds of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of seconds.</returns>
  public static TimeSpan Seconds(this long seconds) => Seconds((double)seconds);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of seconds.
  /// </summary>
  /// <param name="seconds">The seconds of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of seconds.</returns>
  public static TimeSpan Seconds(this float seconds) => Seconds((double)seconds);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of seconds.
  /// </summary>
  /// <param name="seconds">The seconds of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of seconds.</returns>
  public static TimeSpan Seconds(this double seconds) => TimeSpan.FromSeconds(seconds);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of minutes.
  /// </summary>
  /// <param name="minutes">The minutes of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of minutes.</returns>
  public static TimeSpan Minutes(this int minutes) => Minutes((double)minutes);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of minutes.
  /// </summary>
  /// <param name="minutes">The minutes of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of minutes.</returns>
  public static TimeSpan Minutes(this long minutes) => Minutes((double)minutes);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of minutes.
  /// </summary>
  /// <param name="minutes">The minutes of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of minutes.</returns>
  public static TimeSpan Minutes(this float minutes) => Minutes((double)minutes);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of minutes.
  /// </summary>
  /// <param name="minutes">The minutes of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of minutes.</returns>
  public static TimeSpan Minutes(this double minutes) => TimeSpan.FromMinutes(minutes);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of hours.
  /// </summary>
  /// <param name="hours">The hours of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of hours.</returns>
  public static TimeSpan Hours(this int hours) => Hours((double)hours);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of hours.
  /// </summary>
  /// <param name="hours">The hours of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of hours.</returns>
  public static TimeSpan Hours(this long hours) => Hours((double)hours);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of hours.
  /// </summary>
  /// <param name="hours">The hours of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of hours.</returns>
  public static TimeSpan Hours(this float hours) => Hours((double)hours);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of hours.
  /// </summary>
  /// <param name="hours">The hours of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of hours.</returns>
  public static TimeSpan Hours(this double hours) => TimeSpan.FromHours(hours);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of days.
  /// </summary>
  /// <param name="days">The days of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of days.</returns>
  public static TimeSpan Days(this int days) => Days((double)days);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of days.
  /// </summary>
  /// <param name="days">The days of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of days.</returns>
  public static TimeSpan Days(this long days) => Days((double)days);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of days.
  /// </summary>
  /// <param name="days">The days of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of days.</returns>
  public static TimeSpan Days(this float days) => Days((double)days);

  /// <summary>
  /// Returns a new <see cref="TimeSpan"/> with the specified amount of days.
  /// </summary>
  /// <param name="days">The days of the time span.</param>
  /// <returns>A <see cref="TimeSpan"/> with the specified amount of days.</returns>
  public static TimeSpan Days(this double days) => TimeSpan.FromDays(days);
}