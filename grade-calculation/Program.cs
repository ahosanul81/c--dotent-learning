using System;

class GradeCalculation
{
    private static void Main()
    {
        int num;
        Console.Write("Input a number (0-100)");
        num = Convert.ToInt16(Console.ReadLine());
        if (num >= 0 && num <= 59)
        {
            Console.WriteLine("Fail");
        }
        else if (num >= 60 && num <= 69)
        {
            Console.WriteLine("D");
        }
        else if (num >= 70 && num <= 79)
        {
            Console.WriteLine("C");
        }
        else if (num >= 80 && num <= 89)
        {
            Console.WriteLine("B");
        }
        else if (num >= 90 && num <= 100)
        {
            Console.WriteLine("A");
        }
        else
        {
            Console.WriteLine("Invalid number");

        }

    }
}