using System;

class Calculator
{
    public static void Main()
    {
        int num1, num2;
        string operation;

        Console.Write("Input number 1: ");
        num1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Input Operation: ");
        operation = Console.ReadLine();
        Console.Write("Input number 2: ");
        num2 = Convert.ToInt16(Console.ReadLine());


        int result = operation switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "*" => num1 * num2,
            "/" => num1 / num2,
            _ => 0
        };
        Console.WriteLine($"result: {result}");
    }
}