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
    }
}