using System;
using FizzBuzz;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzGeneratorTests
    {
        [Fact]
        public void FizzBuzz()
        {
            var fizzBuzzGenerator = new FizzBuzzGenerator();

            Assert.Equal("1", fizzBuzzGenerator.FizzBuzz(1));
            Assert.Equal("2", fizzBuzzGenerator.FizzBuzz(2));
            Assert.Equal("Fizz", fizzBuzzGenerator.FizzBuzz(3));
            Assert.Equal("Buzz", fizzBuzzGenerator.FizzBuzz(5));
            Assert.Equal("Fizz", fizzBuzzGenerator.FizzBuzz(6));
            Assert.Equal("Fizz", fizzBuzzGenerator.FizzBuzz(9));
            Assert.Equal("Buzz", fizzBuzzGenerator.FizzBuzz(10));
            Assert.Equal("FizzBuzz", fizzBuzzGenerator.FizzBuzz(15));
            Assert.Equal("FizzBuzz", fizzBuzzGenerator.FizzBuzz(30));
        }
    }
}
