using System;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Sorting
{
    public static void Main()
    {

        int[] numbers = { 1, 2, 3, 5, 6, 8, 7, 87, 34 };
        // order  by ascending
        Console.WriteLine("order by ascending");
        var sortedNums = numbers.OrderBy(num => num).ToArray();
        PrintArray(sortedNums);
        // order  by decending
        Console.WriteLine("order by decending");
        var sortedNums2 = numbers.OrderByDescending(num => num).ToArray();
        PrintArray(sortedNums2);


        // for Person class
        Console.WriteLine("order for Person class");
        List<Person> persons = new List<Person>{
            new Person{Name= "Ahosan", Age= 25},
            new Person{Name= "Shamim", Age= 23},
            new Person{Name= "Nahid", Age= 30},
            new Person{Name= "Nahid", Age= 20},
        };

        var sortedPerson = persons.OrderBy(p => p.Name).ThenBy(p => p.Age);
        PrintPerson(sortedPerson);
    }


    public static void PrintArray(int[] nums)
    {
        Console.Write("[");
        foreach (int num in nums)
        {
            Console.Write($"{num}, ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
    public static void PrintPerson(IEnumerable<Person> nums)
    {
        Console.Write("[");
        foreach (Person num in nums)
        {
            // Console.Write($" '{' Name: {num.Name}, Age: {num.Age} '}'");
            Console.Write($"{{ Name: {num.Name}, Age: {num.Age} }}, ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}