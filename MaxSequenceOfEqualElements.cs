﻿using System;
using System.Linq;
namespace _06.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int counter = 1;
            int counterMax = 0;
            int currentNumberMax = 0;

            for (int i = 0; i < integers.Length - 1; i++)
            {
                if (integers[i] == integers[i + 1])
                {
                    counter++;
                }
                else
                {
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        currentNumberMax = integers[i];
                    }
                    counter = 1;
                }

                if (i + 1 == integers.Length - 1)
                {
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        currentNumberMax = integers[i];
                    }
                    counter = 1;
                }
            }
            for (int i = 0; i < counterMax; i++)
            {
                Console.Write($"{currentNumberMax} ");
            }
            Console.WriteLine();
        }
    }
}
