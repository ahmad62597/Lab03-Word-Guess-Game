using System;
using System.IO;

namespace Lab03_GuessingGame
{
    class Program
    {
        public static string path = "../../../../../words.txt";


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MainMenu();
            Console.ReadKey();
            

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

        {   //read users input from main menu and directs them to appropriate section
            
            if (userInput == "1")
            {
                PlayGame();
            }

            if (userInput == "2")
            {
                //EndGame();
            }

            if (userInput == "3")
            {
                SettingMenu();
            }

        }

        static void SettingMenu()
        {
            //options within the settings
            Console.WriteLine("Press 1 to view words in your word bank.");
            Console.WriteLine("Press 2 to add words to your word bank.");
            Console.WriteLine("Press 3 to remove words from your word bank.");
            Console.WriteLine("Press 4 to go back to the main menu.");
            Console.WriteLine("Press 5 to exit the game.");

            //check user input
            string userInput = Console.ReadLine();
            ReadSettingMenuInput(userInput);

        }

        static void ReadSettingMenuInput(string userInput)
        {
            {   //read users input from settings menu and directs them to appropriate section

                if (userInput == "1")
                {
                   
                    ViewWord();
                }

                if (userInput == "2")
                {
                    AddWord();
                }

                if (userInput == "3")
                {
                    //RemoveWord();
                }

                if (userInput == "4")
                {
                    MainMenu();
                }

                if (userInput == "5")
                {
                    //ExitGame();
                }

            }

        }

        static void ViewWord()
        {
            using (StreamReader streamReader = File.OpenText(path))
            {

                Console.WriteLine("KeyBank:");
                while (!streamReader.EndOfStream)
                {

                    Console.WriteLine(streamReader.ReadLine());
                  

                }

            }
            Console.ReadKey();
            SettingMenu();
        }

        static void AddWord()
        {
            Console.WriteLine("Please write the word that you would like to add.");
            string userInput = Console.ReadLine();

            using (StreamWriter streamWriter = File.AppendText(path))
            {
                streamWriter.WriteLine(userInput);
                streamWriter.Close();
            }
            Console.WriteLine($"The word {userInput} has been added.");
            SettingMenu();
        }


        static void PlayGame() 
            {


    }

        static int GetRandomNumber(){
      
            int counter = 0;

            using (StreamReader streamReader = File.OpenText(path)) {
                while (streamReader.ReadLine() !=null){ //counting amount of words
                    counter ++;
                    }

            }

            Random randomNumber = new Random();
            return randomNumber.Next(1, counter + 1);

         }

        }

    static string GetRandomWord(){

        int randomNumber = GetRandomNumber();
        string randomWord = "Yes";
        using (StreamReader streamReader = File.OpenText(path)) {
                for (i = 0; i < randomNumber; i++ ){

                 randomWord = streamReader.ReadLine();
                
                    }
                
                }  
        return randomWord;

  }

}

      

    