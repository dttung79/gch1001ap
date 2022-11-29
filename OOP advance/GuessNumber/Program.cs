using GuessNumber;
using System;

Player p1, p2;  // Declare two players (null)
System.Console.Write("Enter your name: ");
string name = Console.ReadLine();
// Ask user to play first or second
Console.Write("Do you want to play first (y/n): ");
if (Console.ReadLine() == "y")
{
    p1 = new Player(name);
    p2 = new Bot();
}
else
{
    p1 = new Bot();
    p2 = new Player(name);
}

bool playing = true;
while (playing)
{
    p1.GenerateNumber();
    System.Console.WriteLine(p1.Name + " has a number. Can you guess it?");
    int n = p2.GuessNumber();
    int bet = p2.Bet();
    bool win = n == p1.Number;
    if (win) Console.WriteLine(p2.Name + " win!");
    else     Console.WriteLine(p2.Name + " lose!");
    p2.UpdateBalance(bet, win);
    p1.UpdateBalance(bet, !win);

    Console.WriteLine(p1.Name + " balance: " + p1.Balance);
    Console.WriteLine(p2.Name + " balance: " + p2.Balance);

    playing = p1.Balance > 0 && p2.Balance > 0;
}