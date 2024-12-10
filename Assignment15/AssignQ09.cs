using System;
using System.Threading.Tasks;

//Deadlock Scenario
//Write a program that demonstrates a potential deadlock when async and await are used incorrectly. Discuss how to fix the issue.

class Program
{
    static async Task MethodA()
    {
        Console.WriteLine("MethodA started.");
        await Task.Delay(1000).ConfigureAwait(false);  // Use ConfigureAwait(false) to avoid returning to the UI thread
        Console.WriteLine("MethodA completed.");
    }

    static async Task MethodB()
    {
        // No deadlock because we're using async/await properly
        await MethodA();  // Correctly using await without blocking the thread
    }

    static async Task Main(string[] args)
    {
        try
        {
            await MethodB();  // Calling MethodB, which now works without a deadlock
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
        Console.ReadLine();
    }
}
