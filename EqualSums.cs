using System;
using System.Linq;
namespace _11.EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool isFound = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int[] firstArray = numbers.Take(i).ToArray();
                int[] secondArray = numbers.Skip(i + 1).ToArray();
                if (firstArray.Sum() == secondArray.Sum())
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
