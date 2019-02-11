using System;
using System.Collections.Generic;
namespace _04.SieveOfEratosthenes
{
    class SieveOfErathostene
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool[] primes = new bool[number + 1];
            for (int i = 2; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (primes[i])
                {
                    for (int j = i * i; j <= number; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }
            List<int> result = new List<int>();
            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
