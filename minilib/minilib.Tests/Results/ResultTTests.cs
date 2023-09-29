using minilib.Results;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Tests.Results;

[TestFixture]
internal class ResultTTests
{
  [Test]
  public void Successful_ResultHasNoExceptionAndIsSuccessful()
  {
    Result<string> result = Result<string>.Success("test");

    Assert.IsTrue(result.Successful);
    Assert.IsNull(result.Exception);
  }

  [Test]
  public void Error_ResultHasExceptionAndIsNotSuccessful()
  {
    Result<string> result = Result<string>.Error(new Exception());

    Assert.IsFalse(result.Successful);
    Assert.IsNotNull(result.Exception);
  }

  [Test]
  public void Error_ResultExceptionNullThrows()
  {
    Assert.Throws<ArgumentNullException>(() => Result<string>.Error(null!));
  }

  [Test]
  public void Successful_ValueIsMaintained()
  {
    Result<string> result = Result<string>.Success("test");

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
    Result<string> result = new Exception();

    Assert.IsFalse(result.Successful);
    Assert.IsNotNull(result.Exception);
  }
}
