using CalculatorLib;

namespace TestProjectXUnit
{
    public class UnitTest1
    {
        

        [Fact]
        public void AddTestMethod()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);
            Assert.Equal(3, result); 
        }

        [Fact]
        public void SubtractTestMethod()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Subtract(2, 2);
            Assert.Equal(0,result); 
        }

        [Fact]
        public void MultiplyTestMethod()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Multiply(2, 8);
            Assert.Equal(16,result);
        }

        [Fact]
        public void DivideTestMethod()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Divide(2, 2);
            Assert.Equal(0, result); 
        }
    }
}