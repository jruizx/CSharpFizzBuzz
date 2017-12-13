using System;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public string FizzBuzz(int number) {

            if(number < 1 && number > 100) throw new ArgumentOutOfRangeException();

            if(number % 5 == 0 && number % 3 == 0) return "FizzBuzz";
            if(number % 5 == 0) return "Buzz";
            if(number % 3 == 0) return "Fizz";
           
            return number.ToString();
        }
    }
}
