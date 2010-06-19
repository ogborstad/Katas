using System.Collections.Generic;
using FizzbuzzKata;
using NUnit.Framework;

namespace FizzbuzzTests
{
    [TestFixture]
    public class FizzbuzzTests
    {
        public Fizzbuzz fizzbuzz;
        private string _result;

        [SetUp]
        public void SetUp()
        {
            fizzbuzz = new Fizzbuzz();
        }


        [Test]
        public void assure_numbers_not_divisible_by_3_or_5_returns_number()
        {
            var numbers =new List<int>() {0, 1, 2, 4, 7, 8, 11, 13,14};
            foreach (var number in numbers)
            {
                Given(number);
                Expect(number.ToString());
            }
        }
        

        [Test]
        public void assure_three_returns_fizz()
        {
            Given(3);
            Expect("fizz");
        }

        [Test]
        public void assure_five_returns_buzz()
        {
            Given(5);
            Expect("buzz");
        }

        [Test]
        public void assure_six_returns_fizz()
        {
            Given(6);
            Expect("fizz");
        }

        [Test]
        public void assure_ten_returns_buzz()
        {
            Given(10);
            Expect("buzz");
        }

        [Test]
        public void assure_15_returns_fizzbuzz()
        {
            Given(15);
            Expect("fizzbuzz");
        }

        [Test]
        public void assure_13_returns_fizz()
        {
            Given(13);
            Expect("fizz");
        }

        private void Given(int number)
        {
            _result = fizzbuzz.getAnswer(number);
        }

        private void Expect(string excpected)
        {
            Assert.AreEqual(excpected, _result);
        }
    }
}
