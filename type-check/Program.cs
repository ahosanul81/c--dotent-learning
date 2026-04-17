using System;

class TypeCheck
{
    private static void Main()
    {
        object number = "10";

        string result = number switch
        {
            int => "Integer",
            string => "String",
            double => "Double",
            _ => "Invalid"
        };
        Console.WriteLine($"{result}");
    }
}

