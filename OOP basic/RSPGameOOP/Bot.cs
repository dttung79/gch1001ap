using System;

namespace RSPGameOOP
{
    public class Bot
    {
        public string GetChoice()
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