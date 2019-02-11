using System;
using System.Linq;
namespace _07.SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            if (arr1.Length <= arr2.Length)
            {
                int maxArrElements = arr2.Length;
                for (int i = 0; i <= arr2.Length; i++)
                {
                    maxArrElements = (arr1[i % arr1.Length] + arr2[i % arr2.Length]);
                    if (i >= arr2.Length)
                    {
                        break;
                    }
                    Console.Write($"{maxArrElements} ");
                }
            }
            else
            {
                int maxArrElements = arr1.Length;
                for (int i = 0; i <= arr1.Length; i++)
                {
                    maxArrElements = (arr1[i % arr1.Length] + arr2[i % arr2.Length]);
                    if (i >= arr1.Length)
                    {
                        break;
                    }
                    Console.Write($"{maxArrElements} ");
                }
            }
            Console.WriteLine();
        }
    }
}
