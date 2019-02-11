using System;
using System.Linq;
namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numRotation = int.Parse(Console.ReadLine());
            int[] sum = new int[integers.Length];
           // int[] reversedArr = new int[integers.Length];
            for (int r = 1; r <= numRotation; r++)
            {
                integers = Revers(integers);
                for (int i = 0; i < integers.Length; i++)
                {
                    sum[i] += integers[i];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
        static int[] Revers (int [] integers)
        {
            int[] reversed = new int[integers.Length];
            int lastElement = integers[integers.Length - 1];
            for (int i = 1; i < reversed.Length; i++)
            {
                reversed[i] = integers[i - 1];
            }
            reversed[0] = lastElement;
            return reversed;
        }
    }
}
