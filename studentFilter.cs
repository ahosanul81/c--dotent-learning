class Student
{
    public string Name { get; set; }
    public int Score { get; set; }
}

class List
{
    public static void Main()
    {
        List<Student> students = new List<Student> {
            new Student {Name= "Ahosanul", Score= 23},
            new Student {Name= "Shamim", Score= 85},
            new Student {Name= "Rakib", Score= 28}
        };

        var scoreMoreThan80 = students.Where(s => s.Score > 80);
        Console.WriteLine($"Count of student more than 80: {scoreMoreThan80.Count()}");

        if (scoreMoreThan80.Any())
        {
            Console.WriteLine($"List of student more than 80: ");
            foreach (var item in scoreMoreThan80)
            {
                Console.Write($"{item.Name}, {item.Score}");
            }
        }
        else
        {
            Console.WriteLine("No student found more than 80");
        }
    }
}