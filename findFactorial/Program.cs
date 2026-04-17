using System;

class FindFactorial
{
    public static void Main()
    {
        int num;
        Console.Write("Input number: ");
        num = Convert.ToInt16(Console.ReadLine());
        int factorial = 1;
        for (int i = num; i >= 1; i--)
        {
            factorial *= i;
        }

        Console.WriteLine($"Factorial of {num}: {factorial}");
    }
}