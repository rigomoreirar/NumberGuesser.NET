using System;
//using System.Runtime.CompilerServices;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;


// Namespace
namespace NumberGuesser
{

    //Main Class
    internal class Program
    {

        private static void ConsoleWrite(string message, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;

            // Write the message with the specified color
            Console.WriteLine(message);

            // Reset the text color to the default
            Console.ResetColor();
        }

        private static void showAppInfo ()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Rigoberto Moreira";



            // Write out app info
            ConsoleWrite(appName + ": version " + appVersion + " by " + appAuthor, ConsoleColor.Green);
        }

        private static string GreetUser ()
        {
            //Ask user name
            ConsoleWrite("\nWhat is yout name?", ConsoleColor.Yellow);

            //Get user input
            string userName = Console.ReadLine();

            return userName;
        }



        // Entry Point Method
        static void Main(string[] args)
        {

            showAppInfo();

            string userName = GreetUser();

            while (true)
            {

                ConsoleWrite("\nHello " + userName + ", let's play a game...", ConsoleColor.Yellow);

                // Init correct number
                // Random Object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);


                // Init guess var
                int guess = 0;

                // Ask user for number
                ConsoleWrite("\nGuess a number between 1 and 10", ConsoleColor.Yellow);

                while (guess != correctNumber)
                {
                    // Get user guess
                    string userInputGuess = Console.ReadLine();
                    // Check if userInputGuess is int
                    if (!int.TryParse(userInputGuess, out guess))
                    {
                        ConsoleWrite("NOT a Number!", ConsoleColor.Red);
                    }
                    else
                    {
                        // Cast to int and put in guess
                        guess = Int32.Parse(userInputGuess);

                        if (guess != correctNumber)
                        {
                            // Tell user it is the wrong number
                            ConsoleWrite("WRONG Number", ConsoleColor.Red);
                        }
                    }

                }

                // Exit game and tell user it is the right number
                ConsoleWrite("\nYour number is correct!", ConsoleColor.Green);

                ConsoleWrite("\nWould you like to play again? [Y or N]", ConsoleColor.Yellow);
                
                string userAnswer = Console.ReadLine();


               
                if (userAnswer.ToUpper() == "Y") {
                    continue;
                } else if (userAnswer.ToUpper() == "N")
                {
                    ConsoleWrite("\nPress ENTER to exit", ConsoleColor.Yellow);
                    Console.ReadLine();
                    return;
                } else
                {
                    ConsoleWrite("\nPress ENTER to exit", ConsoleColor.Yellow);
                    Console.ReadLine();
                    return;
                }

            }
        }

    }
}
