using System;
using System.Linq;
namespace _06.ReverseAnArrayOfStrings
{
    class ReverseAnArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine()
                .Split(' ')
                .Reverse()
                .ToArray();
                Console.WriteLine(string.Join(" ",elements));
        }
    }
}
