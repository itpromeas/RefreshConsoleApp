using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchExercise
{
    public class Commands
    {
        private static readonly string _MESSAGE = "Please enter a valid option from the options above.";
        public static void Run()
        {
            Console.WriteLine("StopWatch Console App");
            Console.WriteLine("Enter 1 to start the StopWatch");
            Console.WriteLine("Enter 2 to stop the StopWatch");
            Console.WriteLine("Enter 3 to reset the StopWatch");
            Console.WriteLine("Enter 0 to exit the program");
            Console.WriteLine("Choose desired operation from the options above.");

            var stopwatch = new Stopwatch();
            int command = -1;

            do
            {
                try
                {
                    command = int.Parse(Console.ReadLine());
                    switch (command)
                    {
                        case 1:
                            {
                                stopwatch.Start();
                                break;
                            }
                        case 2:
                            {
                                stopwatch.Stop();
                                break;
                            }
                        case 3:
                            {
                                stopwatch.Reset();
                                break;
                            }

                        case 0:
                            {
                                Console.WriteLine("End of stopwatch App.");
                                Console.ReadLine();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine(_MESSAGE);
                                break;
                            }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error details: {0}", ex.Message);
                    Console.WriteLine("Please enter a valid option from the options above.");
                }
            } while (command != 0);
        }
    }
}
