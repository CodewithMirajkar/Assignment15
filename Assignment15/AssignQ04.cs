

////Sequential vs Parallel Tasks
//Write a program that demonstrates sequential and parallel execution of three tasks using async and await. Measure and compare the time taken for both approaches.Write a program that simulates a time-consuming operation (e.g., downloading a file). Use async and await to simulate a 3-second delay before printing "Download Complete."

using System;
using System.Diagnostics;
using System.Threading.Tasks;

class AssignQ04
{
    static async Task DoWorkAsync(int taskId, int delayMilliseconds)
    {
        Console.WriteLine($"Task {taskId} starting...");
        await Task.Delay(delayMilliseconds);
        Console.WriteLine($"Task {taskId} completed after {delayMilliseconds}ms");
    }
    static async Task RunSequentially()
    {
        await DoWorkAsync(1, 1000);
        await DoWorkAsync(2, 2000);
        await DoWorkAsync(3, 3000);
    }
    static async Task RunInParallel()
    {
        await Task.WhenAll(
            DoWorkAsync(1, 1000),
            DoWorkAsync(2, 2000),
            DoWorkAsync(3, 3000)
        );
    }

    static async Task Main(string[] args)
    {
        var stopwatch = Stopwatch.StartNew();
        Console.WriteLine("Running tasks sequentially");
        await RunSequentially();
        stopwatch.Stop();
        Console.WriteLine($"Sequential execution time: {stopwatch.ElapsedMilliseconds} ms");

        Console.WriteLine("\n---");

        stopwatch.Restart();
        Console.WriteLine("Running tasks in parallel");
        await RunInParallel();
        stopwatch.Stop();
        Console.WriteLine($"Parallel execution time: {stopwatch.ElapsedMilliseconds} ms");
        Console.ReadLine();
    }
}
