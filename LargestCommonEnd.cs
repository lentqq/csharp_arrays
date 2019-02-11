using System;
using System.Linq;
namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] words1 = Console.ReadLine().Split(' ').ToArray();
            string[] words2 = Console.ReadLine().Split(' ').ToArray();
            int leftCounter = 0;
            int rightCounter = 0;
            for (int i = 0; i < Math.Min(words1.Length, words2.Length); i++)
            {
                if (words1[i] == words2[i])
                {
                    leftCounter++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < Math.Min(words1.Length, words2.Length); i++)
            {
                if (words1[words1.Length - 1 - i] == words2[words2.Length - 1 - i])
                {
                    rightCounter++;
                }
                else
                {
                    break;
                }
            }
            if (leftCounter > rightCounter)
            {
                Console.WriteLine(leftCounter);
            }
            else
            {
                Console.WriteLine(rightCounter);
            }
        }
    }
}
