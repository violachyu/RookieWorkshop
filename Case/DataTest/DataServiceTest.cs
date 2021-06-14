using System;
using NSubstitute;
using RookieWorkshop.Services;
using Xunit;

namespace DataTest
{
    public class DataServiceTest
    {
        private IDataService _stubDataService;

        public DataServiceTest()
        {
            this._stubDataService = Substitute.For<IDataService>();
        }

        [Fact]
        public void FizzBuzz_15_Is_FizzBuzz()
        {
            // Arrange
            int number = 15;
            string expected = "FizzBuzz";

            // Act
            var actual = this._stubDataService.FizzBuzz(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FizzBuzz_3_Is_Fizz()
        {
            // Arrange
            int number = 3;
            string expected = "Fizz";

            // Act
            var actual = this._stubDataService.FizzBuzz(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FizzBuzz_5_Is_Buzz()
        {
            // Arrange
            int number = 5;
            string expected = "Buzz";

            // Act
            var actual = this._stubDataService.FizzBuzz(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FizzBuzz_number_Is_number()
        {
            // Arrange
            int number = 11;
            string expected = "11";

            // Act
            var actual = this._stubDataService.FizzBuzz(number);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
