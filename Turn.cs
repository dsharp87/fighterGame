using System;

namespace oop_game 
{
    //managers turn, i believe this is where i wish ti implement the combat logic
    public class Turn
    {
        public bool turnStatus = true;
        public Turn(Player currentPlayer, Player opponent)
        {
            System.Console.WriteLine("*****************************************************************");
            System.Console.WriteLine("This is {0}'s turn!", currentPlayer.playerName);
            System.Console.WriteLine("{0} is the opponent!", opponent.playerName);
            while (turnStatus)
            {
                System.Console.WriteLine("Press 1 to end the turn");
                string endTurnInput = Console.ReadLine();
                if (endTurnInput == "1")
                {
                    turnStatus = false;
                }
            }

        }

    }

}