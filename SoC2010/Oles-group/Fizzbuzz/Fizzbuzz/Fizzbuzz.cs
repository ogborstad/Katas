using System;

namespace FizzbuzzKata
{
    public class Fizzbuzz
    {
        public string getAnswer(int number)
        {
            if (number == 0) return "0";
            if (isDivisable(3,number) && isDivisable(5, number)) return "fizzbuzz";
            if (isDivisable(3,number) ) return "fizz";
            if (isDivisable(5,number)) return "buzz";
            return Convert.ToString(number);
        }

        public bool isDivisable(int divisor, int number)
        {
            return (number % divisor == 0 && number != 0) ;
            

        }



    }
}
