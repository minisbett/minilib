using minilib.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Tests.Extensions;

[TestFixture]
internal class TimeSpanExtensionsTests
{
  [Test]
  public void Successful_TimeAlisases()
  {
    TimeSpan milliseconds = 42.Milliseconds();
    TimeSpan seconds = 43L.Seconds();
    TimeSpan minutes = 44.4f.Minutes();
    TimeSpan hours = 45.5.Hours();
    TimeSpan days = 46.Days();

    Assert.That(milliseconds, Is.EqualTo(TimeSpan.FromMilliseconds(42)));
    Assert.That(seconds, Is.EqualTo(TimeSpan.FromSeconds(43)));
    Assert.That(minutes, Is.EqualTo(TimeSpan.FromMinutes(44.4f)));
    Assert.That(hours, Is.EqualTo(TimeSpan.FromHours(45.5)));
    Assert.That(days, Is.EqualTo(TimeSpan.FromDays(46)));
  }
}
