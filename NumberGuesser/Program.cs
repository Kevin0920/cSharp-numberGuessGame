using System;

namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run Get Info function to get info

            GreetUser(); // Run Greet User function
 

            while(true) {
                // Set correct number
                //int correctNumber = 7;

                Random random = new Random();
                // Set random number to a range 
                int correctNumber = random.Next(1, 10);

                // Int guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number betwwen 1 and 10!");

                while (guess != correctNumber)
                {

                    string input = Console.ReadLine();

                    // Make sure is number 

                    if (!int.TryParse(input, out guess))
                    {
                        // Print error mesage
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual color!");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess 
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");

                    }
                }

                // Output success message


                // Print error message
                PrintColorMessage(ConsoleColor.Blue, "Congratulations! That is right number!");

                // Ask to play again

                Console.WriteLine("Play again? [Y or N]");

                // Get answer 
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    Console.WriteLine("Thank you for play!");
                    return;
                }
                else {
                    return;
                }
            }

        }

        static void GetAppInfo() {
            // Set app variables

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Kevin Ke";

            // Change Text Color 

            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

        }

        static void GreetUser() {
            // Ask users name 
            Console.WriteLine("What is your name?");

            // Get user input 
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play game...", inputName);
            
        }

        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change color when guess is not number  
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }

    }
}
