using System;

class ExceptionHandle
{
    static void Main()
    {
        try
        {
            int num1 = ReadIntgerInput("Input number 1");
            int num2 = ReadIntgerInput("Input number 2");

            int div = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {div}");
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

    static int ReadIntgerInput(string prompt)
    {
        while (true)
        {
            try
            {
                Console.Write($"{prompt}: ");
                int input = Convert.ToInt16(Console.ReadLine());
                return input;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
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
        }
    }
}


