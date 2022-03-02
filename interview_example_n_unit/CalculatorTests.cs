using interview_example_c_sharp;
using NUnit.Framework;

namespace interview_example_n_unit
{
    public class CalculatorTests
    {

        [Test]
        public void Given_IPassTwoAndOne_When_ICallAdd_Then_ReturnThree()
        {
            //arrange
            Calculator calculator = new Calculator();
            int expected = 3;

            //act
            int actual = calculator.Add(2, 1);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
