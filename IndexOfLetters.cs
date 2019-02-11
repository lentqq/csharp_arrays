using System;
using System.Linq;
namespace _09.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] alphabet = new char[26];
            int indexLetter = 0;
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                alphabet[indexLetter] = letter;
                indexLetter++;
            }

            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (currentLetter == alphabet[j])
                    {
                        Console.WriteLine($"{currentLetter} -> {j}");
                    }
                }
            }
        }
    }
}
