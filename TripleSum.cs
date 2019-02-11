using System;
using System.Linq;
namespace _04.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
               .Select(int.Parse)
               .ToArray();
            bool containsTripleSum = false;
            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = a + 1; b < arr.Length; b++)
                {
                    int sum = arr[a] + arr[b];
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{arr [a]} + {arr [b]} == {sum}");
                        containsTripleSum = true;
                    }
                }
            }
            if (!containsTripleSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
