using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(6, 7, 3, 16)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-2, -8, 24, 14)]
        [InlineData(-2, -3, 7, 2)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:
            //Arrange
            var tester = new UnitTestMethods();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = tester.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 5, 3)]
        [InlineData(13, 6, 7)]
        [InlineData(-7, -6, -1)]
        [InlineData(-9, 8, -17)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 4, 8)]
        [InlineData(6, 9, 54)]
        [InlineData(-5, 4, -20)]
        [InlineData(2, 4, 8)]
        public void MultiplyTest(int multiplicand, int multiplier, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Multiply(multiplicand, multiplier);

            //Assert
            Assert.Equal(expected, actual); 
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(9, 2, 4.5)]
        [InlineData(-10, 5, -2)]
        [InlineData(-22, -4, 5.5)]
        public void DivideTest(int quotient, int dividend, double expected)
        {
            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Divide(quotient, dividend);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
