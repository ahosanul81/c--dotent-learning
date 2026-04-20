using System;

class ExceptionHandle
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number:");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter second number:");
            int num2 = Convert.ToInt16(Console.ReadLine());
            int sum = num1 / num2;
            Console.WriteLine($"You entered: {num1} + {num2} = {sum}");
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid integer number. 1,23,45,87");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Good morning!!!!!");
        }

    }
}