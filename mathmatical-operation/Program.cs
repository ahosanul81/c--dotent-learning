using System;

class MathmaticalOperation
{
    public static void Main()
    {
        int num1 = 10;
        int num2 = 3;
        int result;

        result = num1 + num2;
        Console.WriteLine("Add: " + result);
        result = num1 - num2;
        Console.WriteLine("Sub: " + result);
        result = num1 * num2;
        Console.WriteLine("mul: " + result);
        double div = (double)num1 / num2;
        Console.WriteLine("div: " + div.ToString("f2"));
        result = num1 % num2;
        Console.WriteLine("mod: " + result);
    }
}