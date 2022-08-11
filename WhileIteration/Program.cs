using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Print Numbers!");
            Console.WriteLine("2) Guessing Game!");
            Console.WriteLine("3) Exit");

            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers!");
            Console.Write("Type a limit number: ");
            int limit = int.Parse(Console.ReadLine());
            for (int i = 0; i <= limit; i++)
            {
                Console.Write(i.ToString());
                if (i < limit) Console.Write("-");
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.Write("Guess a number between 1 and 10: ");
                int userGuess = int.Parse(Console.ReadLine());
                guesses++;
                if (userGuess == randomNumber) incorrect = false;
            } while (incorrect);

            Console.WriteLine("Correct!, It took you {0} guesses.", guesses);

            Console.ReadLine();
        }
    }
}