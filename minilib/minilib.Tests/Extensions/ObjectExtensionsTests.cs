using minilib.Extensions;
using NuGet.Frameworks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Tests.Extensions;

[TestFixture]
internal class ObjectExtensionsTests
{
  [Test]
  public void Successful_AsUnboxIntObjectToIntDoesntThrow()
  {
    object? obj = 4;

    Assert.DoesNotThrow(() => obj.As<int>());
  }

  [Test]
  public void Error_AsUnboxIntObjectTostringThrows()
  {
    object? obj = 4;

    obj.As<string>();
  }

  [Test]
  public void Successful_AsUnboxIntObjectToIntMaintains()
  {
    object? obj = 42;

    Assert.That(obj.As<int>(), Is.EqualTo(42));
  }

  [Test]
  public void Successful_AsOrDefaultGivesDefault()
  {
    object? obj = "test";

    Assert.That(obj.AsOrDefault<int>(), Is.EqualTo(default(int)));
  }
}
