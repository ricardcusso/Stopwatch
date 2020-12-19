using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var loopLimit = 0; // Unless you plan to use this after your while-loop, just define it when you parse the int
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Welcome to your personal Stopwatch!");
                Console.WriteLine("How many times would you like to use Stopwatch today?: ");
                var userInput = Console.ReadLine();

                // This only checks for empty string...
                if (String.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Must enter a valid number");
                    continue; // When this loops back, we get the whole welcome schpiel again
                }

                // If user input was non-number, this throws a runtime error
                loopLimit = Convert.ToInt32(userInput);

                for (var i = 1; i <= loopLimit; i++)
                {
                    Console.WriteLine("Press Enter to start the Stopwatch:");
                    Console.ReadLine();
                    stopwatch.Start();

                    Console.WriteLine("Press Enter to stop the Stopwatch:");
                    Console.ReadLine();

                    stopwatch.Stop();

                    // Maybe check out string formatting for TimeSpan to see if you can output a nice,
                    // non-standard representation of how long the stopwatch ran for?
                    Console.WriteLine($"Stopwatch time is: {stopwatch.CalculateTime()}");

                    if (i != loopLimit)
                    {
                        // I kind of want this <enter> to restart the stopwatch as well, but that's just personal preference
                        Console.WriteLine("Press Enter to run Stopwatch again:");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Thank you for using Stopwatch. Press any key to exit: ");
                        Console.ReadKey();

                        // This makes total sense -- for now.
                        // But since you've gone through the trouble of binding your loop to a variable,
                        // it would be smart to utilize this now:

                        // isRunning = false; // This stops the while-loop before next iteration
                        // break; // This stops the for-loop immediately
                        return;
                    }
                }
            }

            // (future) If you used your `isRunning` to exit the while-loop, you can do cleanup stuff here
        }
    }
}
