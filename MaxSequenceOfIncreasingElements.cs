using System;
using System.Linq;
namespace _07.MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int counter = 1;
            int counterMax = 0;
            int currentPosition = 0;
            for (int i = 0; i < integers.Length - 1; i++)
            {
                if (integers[i] < integers[i + 1])
                {
                    counter++;
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        currentPosition = i + 1;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            int[] result = new int[counterMax];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = integers[currentPosition - counterMax + 1 + i];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
