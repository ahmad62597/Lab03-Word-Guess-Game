using System;

namespace Lab03_GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        static void MainMenu()
        {   
            //create user menu
            Console.WriteLine("Hello, welcome to Console Hangman.");
            Console.WriteLine("");
            Console.WriteLine("Press 1 to play.");
            Console.WriteLine("Press 2 to exit.");
            Console.WriteLine("Press 3 to go to settings.");
            
            //check user input
            string userInput = Console.ReadLine();
            ReadUserOption(userInput);
        }

        static void ReadUserOption (string userInput)

        {   //read users input from main menu and direct them to appropriate section
            
            if (userInput == "1")
            {
                PlayGame();
            }

            if (userInput == "2")
            {
                EndGame();
            }

            if (userInput == "3")
            {
                Setting();
            }


        }


    }
}
