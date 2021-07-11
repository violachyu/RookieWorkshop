using System;
using NSubstitute;
using RookieWorkshop.Services;
using Xunit;

namespace DataTest
{
    public class DataServiceTest
    {
        private IDataService _stubDataService;
        private IInputService _stubInputService;
        private ICacheService _stubCacheService;


        public DataServiceTest()
        {
            this._stubInputService = Substitute.For<IInputService>();
            this._stubDataService = new DataService(_stubInputService);
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


        // Inline Data Method
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(11, "11")]
        public void FizzBuzz_inlineData(int number, string expected)
        {
            // Act
            var actual = this._stubDataService.FizzBuzz(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, "Foo")]
        [InlineData(10, "Bar")]
        [InlineData(14, "Qix")]
        [InlineData(3, "FooFoo")]
        [InlineData(5, "BarBar")]
        [InlineData(7, "QixQix")]
        [InlineData(11, "11")]
        
        public void FooBarQix_inlineData(int number, string expected)
        {
            //Arrange
            this._stubInputService.GetValue(6).Returns(6);
            this._stubInputService.GetValue(10).Returns(10);
            this._stubInputService.GetValue(14).Returns(14);
            this._stubInputService.GetValue(3).Returns(3);
            this._stubInputService.GetValue(5).Returns(5);
            this._stubInputService.GetValue(7).Returns(7);
            this._stubInputService.GetValue(11).Returns(11);

            // Act
            var actual = this._stubDataService.FooBarQix(number);

            // Assert
            Assert.Equal(expected, actual);
        }


    }
}
