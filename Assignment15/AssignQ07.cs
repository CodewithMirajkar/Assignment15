using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    // A long-running operation that checks for cancellation
    static async Task LongRunningOperationAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Long-running operation started. Type 'cancel' to cancel the operation.");

        for (int i = 0; i < 10; i++)
        {
            // Simulate work by waiting for 1 second
            await Task.Delay(1000);

            // Check if cancellation is requested
            if (cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("Operation was canceled.");
                return; // Exit the method if cancellation is requested
            }

            Console.WriteLine($"Operation is still running... Step {i + 1}");
        }

        Console.WriteLine("Long-running operation completed successfully.");
    }

    static async Task Main(string[] args)
    {
        // Create a CancellationTokenSource
        using (CancellationTokenSource cancellationTokenSource = new CancellationTokenSource())
        {
            // Get the CancellationToken
            CancellationToken token = cancellationTokenSource.Token;

            // Start the long-running operation asynchronously
            Task longRunningTask = LongRunningOperationAsync(token);

            // Wait for the user to input "cancel" to cancel the operation
            Task cancelTask = Task.Run(() =>
            {
                string input;
                do
                {
                    input = Console.ReadLine();
                } while (input?.ToLower() != "cancel");

                // Cancel the task if user types "cancel"
                cancellationTokenSource.Cancel();
                Console.WriteLine("Cancellation requested.");
            });

            // Wait for either the long-running task or cancel task to complete
            await Task.WhenAny(longRunningTask, cancelTask);

            // Ensure the long-running task completes after cancellation
            await longRunningTask;
        }

        Console.WriteLine("Program execution completed.");
        Console.ReadLine();
    }
}
