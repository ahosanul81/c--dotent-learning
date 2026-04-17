using System;
class InputValidation
{
    public static void Main()
    {
        while (true)
        {
            Console.Write("Enter a number (1 to 10): ");
            string input = Console.ReadLine() ?? "";
            input = input.ToLower().Trim();
            if (input == "quit")
            {
                Console.WriteLine("Thank you for visiting here. Good Bye!!!");
                break;
            }
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Please input a valid input. Give a number");
                continue;
            }
            if (!(number >= 1 && number <= 10))
            {
                Console.WriteLine("Number is out of range");
                continue;
            }
            int square = number * number;
            Console.WriteLine($"{number} x {number} = {square}");
        }
    }
}