using System;

namespace _03.LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int sequenceNumbers = int.Parse(Console.ReadLine());
            int[] integers = new int[length];
            integers[0] = 1;
            for (int i = 1; i < length; i++)
            {
                int sequenceSum = 0;
                int counter = 0;
                for (int j = i; j >= 0; j--)
                {
                    sequenceSum += integers[j];
                    counter++;
                    if (counter > sequenceNumbers)
                    {
                        break;
                    }
                }
                integers[i] = sequenceSum;
            }
            Console.Write(string.Join(" ",integers));
            Console.WriteLine();
        }
    }
}
