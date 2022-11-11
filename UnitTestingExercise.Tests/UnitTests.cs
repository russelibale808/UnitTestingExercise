using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]                                //Add test data <-------
        [InlineData(5, 5, 0, 10)]
        [InlineData(8, 2, 1, 11)]
        [InlineData(9, 2, 0, 11)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            Calculator challenge = new Calculator();              // create a Calculator object


            //Act
            int actual = challenge.AddTest(num1, num2, num3);    // call the Add method that is located in the Calculator class
                                                                 // and store its result in a variable named actual

            //Assert
            Assert.Equal(expected, actual);                      //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 0)]                                    //Add test data <-------
        [InlineData(10, 5, 5)]
        [InlineData(10, 2, 8)]
        [InlineData(15, 5, 10)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator challenge = new Calculator();

            //Act
            int actual = challenge.SubtractTest(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]                                    //Add test data <-------
        [InlineData(4, 4, 16)]
        [InlineData(6, 6, 36)]
        [InlineData(7, 5, 35)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator challenge = new Calculator();

            //Act
            int actual = challenge.MultiplyTest(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 2, 4)]                                       //Add test data <-------
        [InlineData(4, 2, 2)]
        [InlineData(6, 2, 3)]
        [InlineData(9, 3, 3)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator challenge = new Calculator();

            //Act
            int actual = challenge.DivideTest(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
