using minilib.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Tests.DependencyInjection;

[TestFixture]
internal class DependencContainerTests
{
  internal class TestClass1
  {
    [Inject]
    public int value;
  }

  internal class TestClass2
  {
    [Inject]
    public int value1;

    [Inject("foo")]
    public int value2;
  }

  internal class TestClass3
  {
    [Inject(Container = "container1")]
    public int value1;

    [Inject(Container = "container2")]
    public int value2;
  }

  internal class TestClass4
  {
    [Inject]
    public int value1;

    [Inject]
    public int value2;
  }

  [Test]
  public void Success_InjectSingleObject()
  {
    TestClass1 testClass = new TestClass1();
    int number = 42;

    DependencyContainer container = new DependencyContainer();
    container.Register(number);
    container.Inject(testClass);

    Assert.That(testClass.value, Is.EqualTo(number));
  }

  [Test]
  public void Success_InjectObjectsOfSameTypeDifferentIdentifier()
  {
    TestClass2 testClass = new TestClass2();
    int number1 = 42;
    int number2 = 45;

    DependencyContainer container = new DependencyContainer();
    container.Register(number1);
    container.Register(number2, "foo");
    container.Inject(testClass);

    Assert.That(testClass.value1, Is.EqualTo(number1));
    Assert.That(testClass.value2, Is.EqualTo(number2));
  }

  [Test]
  public void Success_InjectContainerConstraints()
  {
    TestClass3 testClass = new TestClass3();
    int number1 = 42;
    int number2 = 45;

    DependencyContainer container1 = new DependencyContainer("container1");
    DependencyContainer container2 = new DependencyContainer("container2");
    container1.Register(number1);
    container2.Register(number2);
    container1.Inject(testClass);
    container2.Inject(testClass);

    Assert.That(testClass.value1, Is.EqualTo(number1));
    Assert.That(testClass.value2, Is.EqualTo(number2));
  }

  [Test]
  public void Error_RegisterSameObjectTwiceThrows()
  {
    int number = 42;

    DependencyContainer container = new DependencyContainer();
    container.Register(number);

    Assert.Throws<ArgumentException>(() => container.Register(number, "foo"));
  }

  [Test]
  public void Error_RegisterObjectsOfSameTypeNoIdentifierThrows()
  {
    int number1 = 42;
    int number2 = 45;

    DependencyContainer container = new DependencyContainer();
    container.Register(number1);

    Assert.Throws<ArgumentException>(() => container.Register(number2));
  }

  [Test]
  public void Error_RegisterObjectsOfSameTypeSameIdentifierThrows()
  {
    int number1 = 42;
    int number2 = 45;

    DependencyContainer container = new DependencyContainer();
    container.Register(number1, "foo");

    Assert.Throws<ArgumentException>(() => container.Register(number2, "foo"));
  }

  [Test]
  public void Error_InjectSameObjectTwiceThrows()
  {
    TestClass4 testClass = new TestClass4();
    int number = 42;

    DependencyContainer container = new DependencyContainer();
    container.Register(number);

    Assert.Throws<InvalidOperationException>(() => container.Inject(testClass));
  }
}