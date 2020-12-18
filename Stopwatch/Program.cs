using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var loopLimit = 0;
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Welcome to your personal Stopwatch!");
                Console.WriteLine("How many times would you like to use Stopwatch today?: ");
                var userInput = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Must enter a valid number");
                    continue;
                }

                loopLimit = Convert.ToInt32(userInput);

                    for (var i = 1; i <= loopLimit; i++)
                    {
                        Console.WriteLine("Press Enter to start the Stopwatch:");
                        Console.ReadLine();
                        stopwatch.Start();

                        Console.WriteLine("Press Enter to stop the Stopwatch:");
                        Console.ReadLine();

                        stopwatch.Stop();
                        Console.WriteLine($"Stopwatch time is: {stopwatch.CalculateTime()}");

                        if (i != loopLimit)
                        {
                            Console.WriteLine("Press Enter to run Stopwatch again:");
                            Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine("Thank you for using Stopwatch. Press any key to exit: ");
                            Console.ReadKey();
                            return;
                        }

                    }
            }
        }
    }
}
