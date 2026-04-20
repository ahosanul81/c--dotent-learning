using System;

class Namta
{
    public static void Main()
    {
        Console.Write("Starting number: ");
        int startNum = Convert.ToInt16(Console.ReadLine());
        Console.Write("Ending number: ");
        int endNum = Convert.ToInt16(Console.ReadLine());

        for (int i = startNum; i <= endNum; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            ;
            Console.WriteLine("----------------------");
        }
    }
}