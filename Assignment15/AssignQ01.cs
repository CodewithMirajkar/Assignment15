using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

Basics of async and await
Write a program that simulates a time-consuming operation (e.g., downloading a file). Use async and await to simulate a 3-second delay before printing "Download Complete."


namespace PraticeCode
{
    internal class Async_Awaits01
    {
        public static void Main(string[] agrs)
        {
            demo();
            Console.ReadLine();
        }
        public static async Task FileDownload()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Download Complete");
            });
        }
        public static void demo()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            FileDownload();
            watch.Stop();
        }
    }
}