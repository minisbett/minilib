using minilib.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Tests.Extensions;

[TestFixture]
internal class EnumerableExtensionsTests
{
  [Test]
  public void Successful_To()
  {
    IEnumerable<int> should1 = new int[] { 0, 1, 2, 3, 4, 5 };
    IEnumerable<long> should2 = new long[] { 15, 17, 19 };
    IEnumerable<float> should3 = new float[] { -2f, -1.5f, -1f, -0.5f, 0f };
    IEnumerable<double> should4 = new double[] { 20, 20.25, 20.5, 20.75, 21 };

    Assert.That(0.To(5), Is.EqualTo(should1));
    Assert.That(15.To(19, steps: 2), Is.EqualTo(should2));
    Assert.That((-2f).To(0, 0.5f), Is.EqualTo(should3));
    Assert.That(20d.To(21, 0.25), Is.EqualTo(should4));
  }

  [Test]
  public void Successful_Steps()
  {
    IEnumerable<int> enumerable = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    IEnumerable<int> should = new int[] { 0, 2, 4, 6, 8, 10 };

    Assert.That(enumerable.Steps(2), Is.EqualTo(should));
  }

  [Test]
  public void Successful_AddRange()
  {
    IList<int> enumerable = new List<int> { 0, 1 };
    IList<int> should = new List<int> { 0, 1, 2, 3, 4, 5 };

    enumerable.AddRange(2, 3, 4, 5);
    Assert.That(enumerable, Is.EqualTo(should));
  }
}
