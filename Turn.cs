using System;
using System.Collections.Generic;

namespace oop_game 
{
    //manages turn, i believe this is where i wish ti implement the combat logic system
    // each fighter type will have their own methods for attack
    public class Turn
    {
        //things i'd like to impliment
        //active and bench sections of roster that allow players to swap in and swap out fighters
        //each active fighter gets 1 action, not sure if how to integrate swapping
        //when all active fights have 
        public bool turnStatus = true;
        public Turn(Player currentPlayer, Player opponent)
        {
            System.Console.WriteLine("*****************************************************************");
            System.Console.WriteLine("This is {0}'s turn!", currentPlayer.playerName);
            System.Console.WriteLine("{0} is the opponent!", opponent.playerName);
            while (turnStatus)
            {
                //prompt for what type of action player should do
                System.Console.WriteLine("What would you like to do?/n Press 1 to tell a fighter to act /n Press 2 to swap fights to and from bench /n Press 3 to end turn now");
                string actionChoice = Console.ReadLine();
                //end turn
                if (actionChoice == "3")
                {
                    turnStatus = false;
                }
                //fight
                else if(actionChoice == "1")
                {
                    //get list of fighters who can still fight this turn
                    List<Human> availableFighters = new List<Human>();
                    foreach(Human figher in currentPlayer.roster)
                    {
                        if(!figher.hasActed && figher.isAlive)
                        {
                            availableFighters.Add(figher);
                        }
                    }
                    //select which fighter will act
                    System.Console.WriteLine("Which fighter would you like to act?");
                    int counter = 1;
                    foreach(Human fighter in availableFighters)
                    {
                        System.Console.WriteLine(counter + " {0} - {1}", fighter.name, fighter.GetType().Name);
                    }
                    string fighterChoice = Console.ReadLine();
                    //think about how to impliment action list


                }
            }
        }

    }

}