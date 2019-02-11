using System;
using System.Linq;

namespace exercises
{
    class exercises
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().
                Split(" ").
               ToArray();

            words = words.Reverse().ToArray();
            Console.WriteLine(string.Join(Environment.NewLine ,words));
        }
    }
}
