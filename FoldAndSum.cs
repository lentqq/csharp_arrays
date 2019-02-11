using System;
using System.Linq;
namespace _03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = integers.Length / 4;
            int[] leftArr = integers.Take(k).ToArray();
            int[] middleArr = integers.Skip(k).Take(2 * k).ToArray();
            int[] rightArr = integers.Skip(3 * k).Take(k).ToArray();
            Array.Reverse(leftArr);
            Array.Reverse(rightArr);
            int[] sumArr = new int[2 * k];
            for (int i = 0; i < k; i++)
            {
                sumArr[i] = leftArr[i] + middleArr[i];
                sumArr[i + k] = rightArr[i] + middleArr[i + k];
            }
            Console.WriteLine(string.Join(" ",sumArr));
        }
    }
}
