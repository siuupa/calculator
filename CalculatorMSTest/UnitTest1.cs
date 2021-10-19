using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing;

namespace CalculatorMSTest
{
    [TestClass]
    public class UnitTest1
    { 
        private Calculator calculator;

    [TestInitialize]
    public void Setup()
    {
        //Arrange
        calculator = new Calculator();
    }

        [TestMethod]
        public void Add_SumOfTwoArguments_ShouldReturnCorrectSum()
        {
            //Act
            var result = calculator.Add(a: 1,b: 2);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CompareValuesAndReturnGreater_FirstArgumentIsGreater_ShouldReturnFirstArgument()
        { 
            //Act
            var result = calculator.CompareValuesAndReturnGreater(a: 3, b: 1);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CompareValuesAndReturnGreater_SecondArgumentIsGreater_ShouldReturnSecondArgument()
        {
            //Act
            var result = calculator.CompareValuesAndReturnGreater(a: 1, b: 4);

            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void CompareValuesAndReturnGreater_ArgumentsAreEqual_ShouldReturnAnyArgument()
        {
            //Act
            var result = calculator.CompareValuesAndReturnGreater(a: 2, b: 2);

            //Assert
            Assert.AreEqual(2, result);
        }
    }
}
