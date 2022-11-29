using System;

namespace GuessNumber
{
    public class Player
    {
        public string Name { get; set; }

        protected int balance;

        protected int number;
        public int Number
        {
            get { return number; }
        }

        public int Balance
        {
            get { return balance; }
        }

        public Player(string name)
        {
            Name = name;
            balance = 100;
        }

        public virtual void GenerateNumber()
        {
            System.Console.Write("Think of a number between 1 and 5: ");
            number = int.Parse(Console.ReadLine());
        }

        public virtual int GuessNumber()
        {
            System.Console.Write("Guess the number: ");
            return int.Parse(Console.ReadLine());
        }

        public virtual int Bet()
        {
            System.Console.Write("How much do you want to bet: ");
            return int.Parse(Console.ReadLine());
        }

        public void UpdateBalance(int bet, bool win)
        {
            if (win) balance += bet;
            else     balance -= bet;
        }

    }
}