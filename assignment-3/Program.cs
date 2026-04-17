using System;

class Assignment3
{
    private static void Main()
    {
        string studentName;
        int age;
        double gpa;
        Console.Write("Student name: ");
        studentName = Console.ReadLine();
        Console.Write("Age: ");
        age = Convert.ToInt16(Console.ReadLine());
        Console.Write("GPA: ");
        gpa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Student name: {studentName}");
        Console.WriteLine($"Student age: {age}");
        Console.WriteLine($"Student gpa: {gpa}");
    }
}