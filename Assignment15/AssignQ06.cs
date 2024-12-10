using System;
using System.Threading.Tasks;

//Exception Handling in Asynchronous Code
//Write a program that calls an asynchronous method which throws an exception. Use a try-catch block to handle the exception and display an appropriate error message.

class Program
{
    static async Task ThrowExceptionAsync()
    {
        Console.WriteLine("Starting asynchronous method");
        await Task.Delay(1000);
        throw new InvalidOperationException("Something went wrong in method!");
    }
    static async Task Main(string[] args)
    {
        try
        {
            await ThrowExceptionAsync();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }

        Console.WriteLine("Program execution completed.");
        Console.ReadLine();
    }
}
