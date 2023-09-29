using minilib.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Tests.Extensions;

[TestFixture]
internal class DateTimeExtensionsTests
{
  [Test]
  public void Successful_MonthAliases()
  {
    DateTime january = 15.January(2023);
    DateTime february = 14.February(2024);
    DateTime march = 13.March(2025);
    DateTime april = 12.April(2026);
    DateTime may = 11.May(2027);
    DateTime june = 10.June(2028);
    DateTime july = 9.July(2029);
    DateTime august = 8.August(2030);
    DateTime september = 7.September(2031);
    DateTime october = 6.October(2032);
    DateTime november = 5.November(2033);
    DateTime december = 4.December(2034);

    Assert.That(january, Is.EqualTo(new DateTime(2023, 1, 15)));
    Assert.That(february, Is.EqualTo(new DateTime(2024, 2, 14)));
    Assert.That(march, Is.EqualTo(new DateTime(2025, 3, 13)));
    Assert.That(april, Is.EqualTo(new DateTime(2026, 4, 12)));
    Assert.That(may, Is.EqualTo(new DateTime(2027, 5, 11)));
    Assert.That(june, Is.EqualTo(new DateTime(2028, 6, 10)));
    Assert.That(july, Is.EqualTo(new DateTime(2029, 7, 9)));
    Assert.That(august, Is.EqualTo(new DateTime(2030, 8, 8)));
    Assert.That(september, Is.EqualTo(new DateTime(2031, 9, 7)));
    Assert.That(october, Is.EqualTo(new DateTime(2032, 10, 6)));
    Assert.That(november, Is.EqualTo(new DateTime(2033, 11, 5)));
    Assert.That(december, Is.EqualTo(new DateTime(2034, 12, 4)));
  }

  [Test]
  public void Error_InvalidDayOfMonthThrows()
  {
    Assert.Throws<ArgumentOutOfRangeException>(() => 42.April(2023));
  }

  [Test]
  public void Error_InvalidYearThrows()
  {
    Assert.Throws<ArgumentOutOfRangeException>(() => 42.April(int.MaxValue));
  }
}
