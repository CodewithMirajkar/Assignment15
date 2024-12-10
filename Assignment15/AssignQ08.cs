using System;
using System.IO;
using System.Threading.Tasks;

//Task-Based Asynchronous Pattern
//Implement a program that reads the contents of a text file asynchronously using the StreamReader.ReadToEndAsync method. Display the contents after reading.

class AssignQ08
{
    // Asynchronous method to read a file and return its contents
    static async Task ReadFileAsync(string filePath)
    {
        try
        {
            // Use StreamReader to read the file asynchronously
            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = await reader.ReadToEndAsync();  // Read all contents of the file asynchronously
                Console.WriteLine("File Contents:");
                Console.WriteLine(content);
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error: The file was not found. {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: An unexpected error occurred. {ex.Message}");
        }
    }

    static async Task Main(string[] args)
    {
        // Ask the user for the file path
        Console.WriteLine("Enter the file path to read:");
        string filePath = Console.ReadLine();

        // Call the ReadFileAsync method to read the contents of the file asynchronously
        await ReadFileAsync(filePath);
        Console.ReadLine();
    }
}
