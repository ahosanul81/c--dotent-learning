using System;

class WhileLoop
{
    public static void Main()
    {
        int num;
        Console.Write("Input number: ");
        num = Convert.ToInt16(Console.ReadLine());
        int factorial = 1;
        int i = num;
        while (i >= 1)
        {
            Console.WriteLine(i);
            factorial *= i;
            i--;
        }
        Console.WriteLine($"Factorial of {num}: {factorial}");



        //  do while 
        int j = 11;
        do
        {
            Console.WriteLine(j);
            j++;
        } while (j <= 10);
    }
}