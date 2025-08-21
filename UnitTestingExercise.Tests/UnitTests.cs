using System;
using Xunit;


using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] 
        [InlineData(1, 1, 1, 3)]
        [InlineData(0, 5, 5, 10)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            var calculator = new Calculator();
            int actual = calculator.Add(num1, num2, num3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)] 
        [InlineData(20, 5, 15)]
        [InlineData(0, 5, -5)]
        public void SubtractTest(int minuend, int subtrahend, int expected)

        {
            var calculator = new Calculator();
            int actual = calculator.Subtract(minuend, subtrahend);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)] 
        [InlineData(5, 5, 25)]
        [InlineData(0, 10, 0)]
        public void MultiplyTest(int num1, int num2, int expected)

        {
            var calculator = new Calculator();
            int actual = calculator.Multiply(num1, num2);        
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)] 
        [InlineData(20, 5, 4)]
        [InlineData(9, 3, 3)]
        public void DivideTest(int num1, int num2, int expected)

        {
            var calculator = new Calculator();
            int actual = calculator.Divide(num1, num2);
            Assert.Equal(expected, actual);
        }
    }
}
