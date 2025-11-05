using System;

namespace BellEquipmentCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // user input with validation and colors 
            int totalSteps;
            while (true)
            {
                Console.Write("Enter total number of steps in the assembly process : ");
                string input = Console.ReadLine()!; // ! to avoid complier warnings

                if (!int.TryParse(input, out totalSteps) || totalSteps <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input Invalid. Please enter a positive number.");
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }

            int currentStep;
            while (true)
            {
                Console.Write("Enter the current step number : ");
                string input = Console.ReadLine()!;

                if (!int.TryParse(input, out currentStep) || currentStep < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input Invalid. Please enter a positive number.");
                    Console.ResetColor();
                }
                else if (currentStep > totalSteps)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Current step cannot be greater than total steps ({totalSteps}).");
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }

            int currentBay;
            while (true)
            {
                Console.Write("Enter the current bay number - Bay:");
                string input = Console.ReadLine()!;

                if (!int.TryParse(input, out currentBay) || currentBay <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input Invalid. Please enter a positive number.");
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }

            // calculations:
            int remainingSteps = totalSteps - currentStep; // steps remaining

            int progressPercent = (int)Math.Round((double)currentStep / totalSteps * 100); // percentage - rounded to the nearest %

            // output
            if (currentStep == totalSteps)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Machine completed assembly — ready for next bay ✅");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"\nMachine currently in Bay {currentBay}");
                Console.WriteLine($"Steps completed : {currentStep} of {totalSteps}");
                Console.WriteLine($"Remaining steps : {remainingSteps}");
                Console.WriteLine($"Progress : {progressPercent}%");
            }

            // keep console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

