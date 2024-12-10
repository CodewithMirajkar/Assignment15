using System;
using System.Threading.Tasks;

//Task.Delay
//Create a program that starts two tasks to simulate two independent processes running simultaneously. Use Task.Delay to represent the process duration and print a message when each task completes.


class Program
{
    static async Task SimulateProcess(string processName, int delay)
    {
        Console.WriteLine($"{processName} started...");
        await Task.Delay(delay);
        Console.WriteLine($"{processName} completed after {delay / 1000} seconds.");

    }
    static async Task Main(string[] args)
    {
        Task task1 = SimulateProcess("Process 1", 3000);
        Task task2 = SimulateProcess("Process 2", 5000);
        await Task.WhenAll(task1, task2);
        Console.WriteLine("Both tasks have completed.");
        Console.ReadLine();
    }
}
