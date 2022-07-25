using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(4, 8, 12, 24)]
        [InlineData(5, -10, -5, -10)]
        [InlineData(-10, -5, 15, 0)]
        [InlineData(0, 0, 0, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, -1)] //Add test data <-------
        [InlineData(8, 4, 4)]
        [InlineData(5, -10, 15)]
        [InlineData(-10, -10, 0)]
        [InlineData(0, 0, 0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)] //Add test data <-------
        [InlineData(4, 8, 32)]
        [InlineData(5, -10, -50)]
        [InlineData(-10, -5, 50)]
        [InlineData(0, 10, 0)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 5, 2)] //Add test data <-------
        [InlineData(-10, -5, 2)]
        [InlineData(-10, 5, -2)]
        [InlineData(0, 10, 0)]
        [InlineData(10, 0, 0)]//Add test data <-------
        public void DivideTest(int dividend, int divisor, int expected)
        {
            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Divide(dividend, divisor);

            //Assert
            Assert.Equal(expected, actual);

        }

        // Fact example (not required)

        [Fact]
        public void BestGameEverTest()
        {
            var test = new Calculator();

            var actual = test.BestGameEver();

            Assert.Equal("FINAL FANTASY 7!", actual);

        }

    }
}
