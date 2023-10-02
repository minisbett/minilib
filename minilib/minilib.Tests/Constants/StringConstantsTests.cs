using minilib.Constants;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Tests.Constants;

[TestFixture]
internal class StringConstantsTests
{
  [Test]
  public void Successful_PrintableAscii()
  {
    string should = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";

    Assert.That(StringConstants.PRINTABLE_ASCII, Is.EqualTo(should));
  }
}
