using System;
using System.Threading.Tasks;
//Returning Values from Asynchronous Methods
//Write an asynchronous method GetSumAsync that takes two integers as parameters, adds them together, and returns the result after a 2-second delay. Call the method and display the result.

namespace AssignQ02
{
    class Program
    {
        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Started");
            Wait();
            Console.WriteLine("Some Method End");
        }
        private static async Task Wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\n10 Seconds wait Completed\n");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started");
            SomeMethod();
            Console.WriteLine("Main Method End");
            Console.ReadLine();
        }
    }
}