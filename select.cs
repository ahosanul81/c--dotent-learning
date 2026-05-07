using System;



class Select
{
    public static void Main()
    {
        int[] numbers = { 1, 3, 5 };
        var squaredNumber = numbers.Select(n => n * n);
        foreach (var item in squaredNumber)
        {
            Console.Write($"{item}, ");
        }

    }
}