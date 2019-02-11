using System;
using System.Linq;
namespace _09.ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
          
            int[] integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            ExtractSomeMiddleElements(integers);         
            Console.WriteLine();
        }

        static void ExtractSomeMiddleElements(int[] integers)
        {
            if (integers.Length == 1)
            {
                Console.WriteLine(string.Join(" ", integers[0]));
                return;
            }
            else
            {
                for (int i = 0; i < integers.Length; i++)
                {
                    if (integers.Length % 2 != 0)
                    {
                        Console.Write(string.Join(", ", integers[integers.Length / 2 - 1], integers[integers.Length / 2], integers[integers.Length / 2 + 1]));
                        break;
                    }
                    if (integers.Length % 2 == 0)
                    {
                        Console.Write(string.Join(", ", integers[integers.Length / 2 - 1], integers[integers.Length / 2]));
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
