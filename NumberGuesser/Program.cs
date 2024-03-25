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

        


        // Entry Point Method
        static void Main(string[] args)
        {
            
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Rigoberto Moreira";


            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

            //Ask user name
            Console.WriteLine("What is yout name");
            
            //Get user input
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", userName);

            // Init correct number

            int correctNumber = 7;

            // Init guess var
            int guess = 0;


            // Exit game
            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }
    }
}
