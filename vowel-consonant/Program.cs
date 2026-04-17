using System;

class VowelConsonant
{
    private static void Main()
    {
        Console.Write("Input a letter: ");
        char letter = Convert.ToChar(Console.ReadLine());
        switch (char.ToLower(letter))
        {
            case 'a':
            case 'e':
            case 'o':
            case 'i':
            case 'u':
                Console.WriteLine($"'{letter}' is Vowel .");
                break;
            default:
                {
                    if (char.IsLetter(letter))
                    {
                        Console.WriteLine($"{letter} is Consonant .");
                    }
                    else
                    {
                        Console.WriteLine($"{letter} is invalid letter .");
                    }
                    break;
                }
        }
    }
}