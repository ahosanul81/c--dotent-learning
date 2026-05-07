using System;
class StringMethod
{
    private static void Main()
    {
        string text = "This is Ahosanul Islam   ";
        bool isEmpty = string.IsNullOrEmpty(text);
        Console.WriteLine($"isEmpty: {isEmpty}");
        bool isAhosanulExist = text.Contains("Ahosanul");
        Console.WriteLine($"isAhosanulExist: {isAhosanulExist}");
        string insertedText = text.Insert(0, "Hi !");
        Console.WriteLine($"insertedText: {insertedText}");
        string removeText = text.Remove(17);
        Console.WriteLine($"removeText: {removeText}");
        string replaceText = text.Replace("Plabon", "Ahosanul");
        Console.WriteLine($"replaceText: {replaceText}");


        string reversedText = new string(text.Reverse().ToArray());
        Console.WriteLine($"reversedText: {reversedText}");
        string upper = text.ToUpper();
        Console.WriteLine($"upper: {upper}");
        string lower = text.ToLower();
        Console.WriteLine($"lower: {lower}");
        string trim = text.Trim();
        Console.WriteLine($"trim: {trim}");
        string substring = trim.Substring(3, 6);
        Console.WriteLine($"substring: {substring}");
    }
}