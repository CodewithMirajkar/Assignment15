using System;
using System.Threading.Tasks;

//Async Constructor Simulation
//Since constructors cannot be async, write a program that initializes a resource asynchronously using a static factory method CreateAsync().

class Resource
{
    public string Data { get; private set; }

    // Private constructor to ensure it is only created via CreateAsync
    private Resource(string data)
    {
        Data = data;
    }

    // Static async factory method to initialize the resource asynchronously
    public static async Task<Resource> CreateAsync()
    {
        // Simulate an asynchronous operation (e.g., reading from a file or database)
        await Task.Delay(2000);  // Simulating a delay (e.g., 2 seconds)

        // Asynchronous resource initialization
        string initializedData = "Resource initialized successfully";

        // Return an instance of Resource
        return new Resource(initializedData);
    }
}

class Program
{
    static async Task Main(string[] args)
    {
        // Use the static async factory method to initialize the resource
        Resource resource = await Resource.CreateAsync();

        // After initialization, display the data
        Console.WriteLine($"Resource Data: {resource.Data}");
        Console.ReadLine();
    }
}
