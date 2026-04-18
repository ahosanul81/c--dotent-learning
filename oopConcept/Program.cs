class Person
{
    public string name;
    private int age;
    public string university;
    Person()
    {
        name = "Default Name";
        age = 10;
        university = "default university";
        Console.WriteLine($"Name: {name} Age: {age} University: {university}");
    }
    public Person(string n, int a, string u)
    {
        name = n;
        age = a;
        university = u;
        Console.WriteLine($"Name: {name} Age: {age} University: {university}");
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 18)
            {
                age = value;
            }
        }
    }
    public void SetValue(string n, int a, string u)
    {
        name = n;
        age = a;
        university = u;
    }
    public void DisplayPerson()
    {
        Console.WriteLine($"Name: {name} Age: {age} University: {university}");
    }

}

class OopConcept
{
    public static void Main()
    {
        Person p1 = new Person("ahosnaul ", 20, "Comilla University");
        p1.Age = 25;
        p1.DisplayPerson();
    }
}