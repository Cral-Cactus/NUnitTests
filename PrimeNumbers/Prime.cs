using System;

namespace PrimeNumbers
{
    public class Prime
    {
        public bool isPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int sqrt = (int)Math.Sqrt(number);

            for (int i = 3; i <= sqrt; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        /*public bool[] OnlyPrimeNumbers(int[] numbers)
        {
            bool[] prime = new bool[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                prime[i] = isPrime(numbers[i]);
            }

            return prime;
        }*/

        public List<int> OnlyPrimeNumbers(List<int> numbers)
        {
            List<int> prime = new List<int>();


            for (int i = 0; i < numbers.Count; i++)
            {
                if (isPrime(numbers[i]))
                {
                    prime.Add(numbers[i]);
                }
            }

            return prime;
        }
    }
}