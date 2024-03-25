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



        // Entry Point Method
        static void Main(string[] args)
        {
            
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Rigoberto Moreira";



            // Write out app info
            ConsoleWrite(appName + ": version " + appVersion + " by " + appAuthor, ConsoleColor.Green);

            //Ask user name
            ConsoleWrite("What is yout name?", ConsoleColor.Yellow);

            //Get user input
            string userName = Console.ReadLine();

            ConsoleWrite("Hello " + userName + ", let's play a game...", ConsoleColor.Yellow);

            // Init correct number

            int correctNumber = 7;

            // Init guess var
            int guess = 0;

            // Ask user for number
            ConsoleWrite("Guess a number between 1 and 10", ConsoleColor.Yellow);

            while (guess != correctNumber) {
                //Get user guess
                string userInputGuess = Console.ReadLine();

                //Cast to int and put in guess
                guess = Int32.Parse(userInputGuess);

                if (guess != correctNumber) { 
                    // Tell user it is the wrong number
                   
                }
            }

            // Exit game and tell user it is the right number
            ConsoleWrite("Your number is correct!", ConsoleColor.Blue);

            ConsoleWrite("Press ENTER to exit", ConsoleColor.White);
            Console.ReadLine();
        }

    }
}
