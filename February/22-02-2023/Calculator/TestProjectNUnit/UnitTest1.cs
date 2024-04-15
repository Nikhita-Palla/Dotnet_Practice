using Calculator;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    private CalculatorClass calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new CalculatorClass();
    }

    [Test]
    public void AddTestMethod()
    {
        int result = calculator.Add(1, 2);
        Assert.That(result, Is.EqualTo(3)); // Using Is.EqualTo constraint
    }

    [Test]
    public void SubtractTestMethod()
    {
        int result = calculator.Subtract(2, 2);
        Assert.That(result, Is.EqualTo(0)); // Using Is.EqualTo constraint
    }

    [Test]
    public void MultiplyTestMethod()
    {
        int result = calculator.Multiply(2, 8);
        Assert.That(result, Is.EqualTo(16)); // Using Is.EqualTo constraint
    }

    [Test]
    public void DivideTestMethod()
    {
        int result = calculator.Divide(2, 2);
        Assert.That(result, Is.EqualTo(1)); // Using Is.EqualTo constraint
    }
}
