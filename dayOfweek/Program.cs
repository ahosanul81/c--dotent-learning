using System;

class DayOfWeek
{
    private static void Main()
    {
        string day;
        Console.Write("Enter a days: ");
        day = Console.ReadLine();

        // switch (day.ToLower())
        // {
        //     case "satarday":
        //         Console.WriteLine($"'{day}' is a weekend");
        //         break;
        //     case "sunday":
        //         Console.WriteLine($"'{day}' is a weekday");
        //         break;
        //     case "monday":
        //         Console.WriteLine($"'{day}' is a weekday");
        //         break;
        //     case "tuesday":
        //         Console.WriteLine($"'{day}' is a weekday");
        //         break;
        //     case "wednessday":
        //         Console.WriteLine($"'{day}' is a weekday");
        //         break;
        //     case "thursday":
        //         Console.WriteLine($"'{day}' is a weekday");
        //         break;
        //     case "friday":
        //         Console.WriteLine($"'{day}' is a weekend");
        //         break;

        //     default:
        //         if (day != "satarday" || day != "sunday" || day != "monday" || day != "tuesday" || day != "wednessday" || day != "thursday" || day != "friday")
        //         {
        //             Console.WriteLine("Invalid day");
        //         }
        //         break;
        // }

        // switch shorthand

        string result = day.ToLower() switch
        {
            "satarday" => "weekend",
            "sunday" => "weekday",
            "monday" => "weekday",
            "tuesday" => "weekday",
            "wednessday" => "weekday",
            "thursday" => "weekday",
            "friday" =>
               "weekend",
            _ => "Invalid day"


        };
        Console.WriteLine($"'{day}' is {result}");
    }
}
