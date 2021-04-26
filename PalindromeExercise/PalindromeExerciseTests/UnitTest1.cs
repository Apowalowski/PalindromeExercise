using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Low", false)]
        public void IsAPalindrome(string myString, bool expected)
        {
            //Arrange
            var test = new WordSmith();
            //Act
            var actual = test.IsAPalindrome(myString);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
