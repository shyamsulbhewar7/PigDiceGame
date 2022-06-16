using PigDiceOOP.Model;
using System;

namespace PigDiceOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before starting the game , lets get to know some rules :");
            Console.WriteLine("1) See how many turns it takes you to get to 20.");
            Console.WriteLine("2) Turn ends when you hold or roll a 1.");
            Console.WriteLine("3) If you roll a 1, you lose all points for the turn");
            Console.WriteLine("4) If you hold, you save all points for the turn");
            PigDice player1 = new PigDice();
            Console.WriteLine("Player took " + player1.Play() + " Turns to reach target");
        }
    }
}
