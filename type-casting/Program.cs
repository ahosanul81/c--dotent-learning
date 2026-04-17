using System;
class TypeCasting
{
    public static void Main(string[] args)
    {
        double salary = 45000.66;
        Console.WriteLine(salary);
        int salary2 = (int)salary;
        Console.WriteLine(salary2);
        Console.WriteLine(Convert.ToString(salary));

        //  parse 
        string num1 = "10.5";
        // int num2 = int.Parse(num1);
        double num2 = double.Parse(num1);
        Console.WriteLine(num2);



        // user input
        Console.Write("Enter your name: ");
        string? studentName = Console.ReadLine();

        Console.WriteLine("Hello " + studentName);

        Console.ReadLine();
    }
}

// implicit / Automatic conversion 
// char > int > long > float > double 

//  explecit 
// double > float > long > int > char   
