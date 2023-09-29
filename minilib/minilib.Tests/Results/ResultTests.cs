using minilib.Results;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Tests.Results;

[TestFixture]
internal class ResultTests
{
  [Test]
  public void Successful_ResultHasNoException()
  {
    Result result = Result.Success;

    Assert.IsTrue(result.Successful);
    Assert.IsNull(result.Exception);
  }

  [Test]
  public void Error_ResultHasException()
  {
    Result result = Result.Error(new Exception());

    Assert.IsFalse(result.Successful);
    Assert.IsNotNull(result.Exception);
  }

  [Test]
  public void Error_ResultNullExceptionThrows()
  {
    Assert.Throws<ArgumentNullException>(() => Result.Error(null!));
  }

  [Test]
  public void Successful_ValueIsMaintained()
  {
    Result<string> result = Result<string>.Success("test");

    Assert.IsTrue(result.Successful);
    Assert.That(result.Value, Is.EqualTo("test"));
  }

  [Test]
  public void Successful_ResultImplicitlySuccessful()
  {
    Result<string> result = "test";

    Assert.IsTrue(result.Successful);
    Assert.That(result.Value, Is.EqualTo("test"));
  }

  [Test]
  public void Successful_ResultImplicitlyFailed()
  {
    Result result = new Exception();

    Assert.IsFalse(result.Successful);
    Assert.IsNotNull(result.Exception);
  }
}
