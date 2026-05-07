using System;



class List
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 1, 3, 5 };
        var evenNum = numbers.Where(num => num % 2 == 0);

        Console.WriteLine($"Count of even number: {evenNum.Count()}");

        if (evenNum.Any())
        {
            Console.Write($"Even numbers: ");
            foreach (var item in evenNum)
            {
                Console.Write($"{item}, ");
            }
        }
        else
        {
            Console.WriteLine("No even number found");
        }
    }
}