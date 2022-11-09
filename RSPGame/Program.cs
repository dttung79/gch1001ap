using System;

namespace RSPGame
{
    class Program
    {
        const int REWARD = 10;
        static void Main(string[] args)
        {
            bool playing = true;
            int balance = EnterBalance();
            while (playing)
            {
                string computerChoice = GetComputerChoice();
                // User chooses rock, paper, or scissors from the console
                string userChoice = GetUserChoice();
                Console.WriteLine("Computer chose " + computerChoice);
                
                // Compare the two choices and determine the winner
                string result = CompareResults(userChoice, computerChoice);
                balance = UpdateBalance(balance, result);
                
                PrintGameStatus(result, balance);
                
                playing = IsEnoughToPlay(balance) && IsContinue();
            }
            PrintFinalStatus(balance);
        }
        static void PrintFinalStatus(int balance)
        {
            Console.WriteLine("Your final balance is " + balance);
            Console.WriteLine("Thanks for playing!");
        }
        static bool IsContinue() 
        {
            Console.Write("Do you want to play again? (y/n): ");
            string playAgain = Console.ReadLine();
            bool playing = playAgain == "y";
            
            return playing;
        }
        static bool IsEnoughToPlay(int balance)
        {
            return balance >= REWARD;
        }

        static void PrintGameStatus(string result, int balance)
        {
            Console.WriteLine("Game result: " + result);
            Console.WriteLine("Your balance is now " + balance);
        }
        static int EnterBalance()
        {
            Console.Write("Enter your balance: ");
            int balance = int.Parse(Console.ReadLine());
            return balance;
        }
        static int UpdateBalance(int balance, string result)
        {
            if (result == "Win") balance += REWARD;
            else if (result == "Lose") balance -= REWARD;
            return balance;
        }
        static string GetUserChoice()
        {
            string userChoice = "";
            bool validChoice = false;
            while (!validChoice)
            {
                Console.Write("Choose Rock, Paper, or Scissors: ");
                userChoice = Console.ReadLine();
                validChoice = userChoice == "Rock" || userChoice == "Paper" || userChoice == "Scissors";
                if (!validChoice)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            return userChoice;
        }

        static string CompareResults(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "Tie";
            }
            else if ((userChoice == "Rock" && computerChoice == "Scissors") ||
                (userChoice == "Paper" && computerChoice == "Rock") ||
                (userChoice == "Scissors" && computerChoice == "Paper"))
            {
                return "Win";
            }
            else
            {
                return "Lose";
            }
        }
        static string GetComputerChoice()
        {
            // Computer chooses a random number between 1 and 3
            Random random = new Random();
            //int computerChoice = random.Next(1, 4);
            string[] choices = { "Rock", "Paper", "Scissors" };
            // convert to string (rock, paper, scissors)
            string computerChoice = choices[random.Next(1, 4) - 1];
            return computerChoice;
        }
    }
}
