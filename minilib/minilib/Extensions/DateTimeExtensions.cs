using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="DateTime"/> class itself and creating instances of it.
/// </summary>
public static class DateTimeExtensions
{
  /// <summary>
  /// Returns a new <see cref="DateTime"/> with the specified day and year of January.
  /// </summary>
  /// <param name="day">The day of the month in January.</param>
  /// <param name="year">The year.</param>
  /// <returns>A <see cref="DateTime"/> with the specified day and year of January.</returns>
  public static DateTime January(this int day, int year)
  {
    return new DateTime(year, 1, day);
  }

  /// <summary>
  /// Returns a new <see cref="DateTime"/> with the specified day and year of February.
  /// </summary>
  /// <param name="day">The day of the month in February.</param>
  /// <param name="year">The year.</param>
  /// <returns>A <see cref="DateTime"/> with the specified day and year of February.</returns>
  public static DateTime February(this int day, int year)
  {
    return new DateTime(year, 2, day);
  }

  /// <summary>
  /// Returns a new <see cref="DateTime"/> with the specified day and year of March.
  /// </summary>
  /// <param name="day">The day of the month in March.</param>
  /// <param name="year">The year.</param>
  /// <returns>A <see cref="DateTime"/> with the specified day and year of March.</returns>
  public static DateTime March(this int day, int year)
  {
    return new DateTime(year, 3, day);
  }

  /// <summary>
  /// Returns a new <see cref="DateTime"/> with the specified day and year of April.
  /// </summary>
  /// <param name="day">The day of the month in April.</param>
  /// <param name="year">The year.</param>
  /// <returns>A <see cref="DateTime"/> with the specified day and year of April.</returns>
  public static DateTime April(this int day, int year)
  {
    return new DateTime(year, 4, day);
  }

  /// <summary>
  /// Returns a new <see cref="DateTime"/> with the specified day and year of May.
  /// </summary>
  /// <param name="day">The day of the month in May.</param>
  /// <param name="year">The year.</param>
  /// <returns>A <see cref="DateTime"/> with the specified day and year of May.</returns>
  public static DateTime May(this int day, int year)
  {
    return new DateTime(year, 5, day);
  }

  /// <summary>
  /// Returns a new <see cref="DateTime"/> with the specified day and year of June.
  /// </summary>
  /// <param name="day">The day of the month in June.</param>
  /// <param name="year">The year.</param>
  /// <returns>A <see cref="DateTime"/> with the specified day and year of June.</returns>
  public static DateTime June(this int day, int year)
  {
    return new DateTime(year, 6, day);
  }

  /// <summary>
  /// Returns a new <see cref="DateTime"/> with the specified day and year of July.
  /// </summary>
  /// <param name="day">The day of the month in July.</param>
  /// <param name="year">The year.</param>
  /// <returns>A <see cref="DateTime"/> with the specified day and year of July.</returns>
  public static DateTime July(this int day, int year)
  {
    return new DateTime(year, 7, day);
  }

  /// <summary>
  /// Returns a new <see cref="DateTime"/> with the specified day and year of August.
  /// </summary>
  /// <param name="day">The day of the month in August.</param>
  /// <param name="year">The year.</param>
  /// <returns>A <see cref="DateTime"/> with the specified day and year of August.</returns>
  public static DateTime August(this int day, int year)
  {
    return new DateTime(year, 8, day);
  }

  /// <summary>
  /// Returns a new <see cref="DateTime"/> with the specified day and year of September.
  /// </summary>
  /// <param name="day">The day of the month in September.</param>
  /// <param name="year">The year.</param>
  /// <returns>A <see cref="DateTime"/> with the specified day and year of September.</returns>
  public static DateTime September(this int day, int year)
  {
    return new DateTime(year, 9, day);
  }

  /// <summary>
  /// Returns a new <see cref="DateTime"/> with the specified day and year of October.
  /// </summary>
  /// <param name="day">The day of the month in October.</param>
  /// <param name="year">The year.</param>
  /// <returns>A <see cref="DateTime"/> with the specified day and year of October.</returns>
  public static DateTime October(this int day, int year)
  {
    return new DateTime(year, 10, day);
  }

  /// <summary>
  /// Returns a new <see cref="DateTime"/> with the specified day and year of November.
  /// </summary>
  /// <param name="day">The day of the month in November.</param>
  /// <param name="year">The year.</param>
  /// <returns>A <see cref="DateTime"/> with the specified day and year of November.</returns>
  public static DateTime November(this int day, int year)
  {
    return new DateTime(year, 11, day);
  }

  /// <summary>
  /// Returns a new <see cref="DateTime"/> with the specified day and year of December.
  /// </summary>
  /// <param name="day">The day of the month in December.</param>
  /// <param name="year">The year.</param>
  /// <returns>A <see cref="DateTime"/> with the specified day and year of December.</returns>
  public static DateTime December(this int day, int year)
  {
    return new DateTime(year, 12, day);
  }

  /// <summary>
  /// Returns whether the specified date is in the future from the specified now date.
  /// </summary>
  /// <param name="date">The date that is potentially in the future.</param>
  /// <param name="now">The reference date that is considered now.</param>
  /// <returns>Bool whether the specified date is in the future from the specified now date.</returns>
  public static bool IsFuture(this DateTime date, DateTime now)
  {
    return date.Date > now.Date;
  }

  /// <summary>
  /// Returns whether the specified date is in the future.
  /// </summary>
  /// <param name="date">The date that is potentially in the future.</param>
  public static bool IsFuture(this DateTime date)
  {
    return date.IsFuture(DateTime.Now);
  }

  /// <summary>
  /// Returns whether the specified date is in the past from the specified now date.
  /// </summary>
  /// <param name="date">The date that is potentially in the past.</param>
  /// <param name="now">The reference date that is considered now.</param>
  /// <returns>Bool whether the specified date is in the past from the specified now date.</returns>
  public static bool IsPast(this DateTime date, DateTime now)
  {
    return date.Date < now.Date;
  }

  /// <summary>
  /// Returns whether the specified date is in the past.
  /// </summary>
  /// <param name="date">The date that is potentially in the past.</param>
  public static bool IsPast(this DateTime date)
  {
    return date.IsPast(DateTime.Now);
  }
}