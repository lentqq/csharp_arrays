using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condenced = new int[nums.Length - 1];
            if (nums.Length == 1)
            {
                Console.WriteLine($"{nums[0]} is already condenced to number");
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < condenced.Length - i; j++)
                {
                    condenced[j] = nums[j] + nums[j + 1];  
                }
                nums = condenced; 
            }
            Console.Write($"{condenced[0]} ");
            Console.WriteLine();
        }
    }
}
