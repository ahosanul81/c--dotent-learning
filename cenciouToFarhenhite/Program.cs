using System;

class CenciouToFarhenhite
{
    public static void Main()
    {
        double f;
        double c;
        Console.Write("Input farhanhite: ");
        f = Convert.ToDouble(Console.ReadLine());
        c = (f - 32) * 5 / 9;
        Console.WriteLine($"{f} farhenhite = {c:f2} degree cencious");


        // celcious to farhanhite

        Console.Write("Input celcious: ");
        c = Convert.ToDouble(Console.ReadLine());
        f = (c * 9 / 5) + 32;
        Console.WriteLine($"{c} celcious = {f:f2} degree farhanhite");

    }
}