using System;

class MathmaticalOperationPractice
{
    public static void Main()
    {

        //  sum , sub , mul ,avg
        int num1;
        int num2;
        int num3;
        int result;
        Console.Write("Num1: ");
        num1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Num2: ");
        num2 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Num3: ");
        num3 = Convert.ToInt16(Console.ReadLine());

        int sum = num1 + num2 + num3;
        Console.WriteLine($"{num1} + {num2} + {num3} = {sum}");
        result = num1 - num2;
        Console.WriteLine($"{num1} - {num2}= {result}");
        result = num1 * num2 * num3;
        Console.WriteLine($"{num1} * {num2} * {num3} = {result}");
        double div = (double)num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {div.ToString("f2")}");
        result = num1 % num2;
        Console.WriteLine($"{num1} % {num2} = {result}");
        double avg = (double)sum / 3;
        Console.WriteLine($"Avg = {avg:f2}");


        // calculation of area of triangle
        // double base, height, area;
        double baseVal;
        double height;
        double area;
        Console.Write("Input base: ");
        baseVal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input height: ");
        height = Convert.ToDouble(Console.ReadLine());

        area = 0.5 * baseVal * height;

        Console.WriteLine($"Area of triangle: {area}");
    }
}