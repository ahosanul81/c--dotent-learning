using System;
class Array
{
    public static void Main()
    {
        string[] names = new String[3] { "Ahosanul Islam", "Rakib", "Miraz" };

        // for (int i = 0; i < names.Length; i++)
        // {
        //     Console.WriteLine(names[i]);
        // }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        int[] numbers = { 2, 4, 6, 34, 56, 88 };
        PrintArray(numbers);
        Console.WriteLine();
        Console.WriteLine($"numbers: [{numbers}] ");
        Console.WriteLine($"Dimenssion: {numbers.Rank}");
        Console.WriteLine($"Max number: {numbers.Max()}");
        Console.WriteLine($"Min number: {numbers.Min()}");
        int index = System.Array.IndexOf(numbers, 4);
        Console.WriteLine($"IndexOf 4: {index}");
        bool isExist = System.Array.Exists(numbers, number => number == 6);
        Console.WriteLine($"isExist 6: {isExist}");
        int[] copy = new int[numbers.Length];
        System.Array.Copy(numbers, copy, numbers.Length);
        Console.Write($"Copied Array: {copy}");
        PrintArray(copy);
    }


    public static void PrintArray(int[] nums)
    {
        Console.Write("[");
        foreach (int num in nums)
        {
            Console.Write($"{num}, ");
        }
        Console.Write("]");
    }
}