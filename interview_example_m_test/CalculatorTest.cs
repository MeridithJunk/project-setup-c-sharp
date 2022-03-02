using interview_example_c_sharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace interview_example_m_test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
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
