using System;
class Test {
    public static void Main(string[] args)
    {
      string assignmentName = "Assignment-2";
      string productName = "Apple Iphone-14";
      double price = 320.5;
      string category = "Smartphone";
      bool availability = true;
      int sellCount = 5;
      Console.WriteLine(assignmentName);
      Console.WriteLine("------------------------");
      Console.WriteLine($"Name: {productName}");
      Console.WriteLine($"price: ${price}");
      Console.WriteLine($"category: {category}");
      Console.WriteLine($"Available:{ availability}");
      Console.WriteLine($"Sold:{ sellCount}");
    } 
}