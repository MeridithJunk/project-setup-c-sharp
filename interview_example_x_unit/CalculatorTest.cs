using interview_example_c_sharp;
using Xunit;

namespace interview_example_x_unit
{
    public class CalculatorTest
    {
        [Fact]
        public void Given_IPassTwoAndOne_When_ICallAdd_Then_ReturnThree()
        {
            var calculator = new Calculator();
            var result = calculator.Add(1, 2);

            Assert.Equal(3, result);
        }
    }
}
