using System;

class Student
{
    private string? _name;
    private DateTime _dateOfBirth;
    private string? _rollNumber;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public DateTime DateOfBirth
    {
        get { return _dateOfBirth; }
        set
        {
            if (value > DateTime.Now)
            {
                throw new ArgumentException("Date of birth can not be in the future.");
            }
            _dateOfBirth = value;
        }
    }
    public string RollNumber
    {
        get { return _rollNumber; }
        set { _rollNumber = value; }
    }

    public Student(string name, DateTime dateOfBirth, string rollNumber)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
        RollNumber = rollNumber;
    }

    private int CalculateAge()
    {
        int age = DateTime.Now.Year - DateOfBirth.Year;
        if (DateTime.Now < DateOfBirth.AddYears(age))
        {
            Console.WriteLine($"from calculateAge class : {age} {DateTime.Now}  < {DateOfBirth.AddYears(age)}");
            age--;
        }
        return age;
    }
    public int Age
    {
        get { return CalculateAge(); }
    }
}
class StudentManagementProject
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Student Management System");
            Student s1 = new Student("Ahosanul Islam", new DateTime(2001, 07, 03), "12103023");
            Console.WriteLine($"{s1.Name}, {s1.RollNumber}, {s1.DateOfBirth} Age: {s1.Age}");
        }
        catch (Exception err)
        {
            Console.WriteLine(err.Message);
        }
    }
}