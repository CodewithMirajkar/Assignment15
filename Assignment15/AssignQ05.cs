using System;
using System.Threading.Tasks;

//Handling Multiple Tasks
// Create a program that uses Task.WhenAll to wait for three tasks to complete. Each task should simulate a different time-consuming operation (e.g., Task1: 2 seconds, Task2: 3 seconds, Task3: 4 seconds). Print a message after all tasks complete.

class AssignQ05
{
    static async Task Task1()
    {
        Console.WriteLine("Task 1 starting...");
        await Task.Delay(2000);
        Console.WriteLine("Task 1 completed after 2 seconds.");
    }

    static async Task Task2()
    {
        Console.WriteLine("Task 2 starting...");
        await Task.Delay(3000);
        Console.WriteLine("Task 2 completed after 3 seconds.");
    }

    static async Task Task3()
    {
        Console.WriteLine("Task 3 starting...");
        await Task.Delay(4000);
        Console.WriteLine("Task 3 completed after 4 seconds.");
    }

    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting tasks...");

        await Task.WhenAll(
            Task1(),
            Task2(),
            Task3()
        );

        Console.WriteLine("\nAll tasks completed!");
        Console.ReadLine();
    }
}
