using System;
using System.Linq;
namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] counters = new int[integers.Length];
            int counterMax = 0;
            int currentNumberMax = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                for (int j = 0; j < integers.Length; j++)
                {
                    if (integers[i] == integers[j])
                    {
                        counters[i]++;
                        if (counters[i] > counterMax)
                        {
                            counterMax = counters[i];
                            currentNumberMax = integers[i];
                        }
                    }
                }
            }
            Console.WriteLine(currentNumberMax);
        }
    }
}
