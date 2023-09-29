using minilib.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Tests.Extensions;

[TestFixture]
internal class StringExtensionsTests
{
  [Test]
  public void Successful_Format()
  {
    Assert.That("Foo {0}".Format("Bar"), Is.EqualTo("Foo Bar"));
  }
}
