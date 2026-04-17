using System;

class EvenOdd
{
    private static void Main()
    {
        int number = 10;

        string result = number switch
        {
            int num when num > 0 && num < 11 => num % 2 == 0 ? "Even" : "Odd",
            _ => "Invalid input or out of range"

        }
          ;
        Console.WriteLine($"{result}");

    }
}

