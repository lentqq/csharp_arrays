using System;
using System.Linq;
namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool isFirst = false;

            for (int i = 0; i < Math.Min(array1.Length,array2.Length); i++)
            {
                if (array1[i] < array2[i])
                {
                    isFirst = true;
                    break;
                }
                else if (array1[i] > array2[i])
                {
                    isFirst = false;
                    break;
                } 
                else if(i == Math.Min(array1.Length,array2.Length) - 1)
                {
                    if (array1.Length < array2.Length)
                    {
                        isFirst = true;
                    }
                }
            }
            if (isFirst)
            {
                Console.WriteLine(string.Join("",array1));
                Console.WriteLine(string.Join("",array2));
            }
            else
            {
                Console.WriteLine(string.Join("", array2));
                Console.WriteLine(string.Join("", array1));
            }
        }
    }
}
