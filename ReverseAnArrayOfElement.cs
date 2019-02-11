using System;

namespace _02.ReverseAnArrayOfElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] integers = new int[length];
            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = integers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{integers[i]} ");
            }
            Console.WriteLine();
        }
    }
}
