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
        //at beging of turn, if bench is not full, check to see if there are alive fighter on bench to fill roster with
        //player gets action count = number of alive fighters on bench
        //each active fighter gets 1 action, using action causes that figher to be inactive and uses a player action point
        //swapping a fighter to bench uses an action point and causes swapped in fighter to be inactive
        //when player has used all actions, or has no more active/alive fighters in field, end turn
        public bool turnStatus = true;
        public Turn(Player currentPlayer, Player opponent)
        {
            System.Console.WriteLine("*****************************************************************");
            System.Console.WriteLine("This is {0}'s turn!", currentPlayer.playerName);
            System.Console.WriteLine("{0} is the opponent!", opponent.playerName);
            while (turnStatus)
            {
                //prompt for what type of action player should do
                
                System.Console.WriteLine("What would you like to do?" + System.Environment.NewLine + "Press 1 to tell a fighter to act" + System.Environment.NewLine + "Press 2 to swap fights to and from bench." + System.Environment.NewLine + "Press 3 to end turn now");
                string actionChoice = Console.ReadLine();
                //validate input
                //THIS SEEMS LIKE IT COULD BE OPTIMIZED TO NOT REPEAT PROMP LINE BEFORE LOOP                
                while(actionChoice != "1" || actionChoice != "2" || actionChoice != "3")
                {
                    System.Console.WriteLine("Please enter the number coresponding to the action you would like to take.");
                    System.Console.WriteLine("What would you like to do?" + System.Environment.NewLine + "Press 1 to tell a fighter to act" + System.Environment.NewLine + "Press 2 to swap fights to and from bench." + System.Environment.NewLine + "Press 3 to end turn now");
                    actionChoice = Console.ReadLine();
                }
                //USE CASE STATEMENT INSTEAD OF IF CHECKS
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
                        if(figher.hasActed == false && figher.isAlive)
                        {
                            availableFighters.Add(figher);
                        }
                    }
                    //select which fighter will act
                    System.Console.WriteLine("Which fighter would you like to act?");
                    int counter = 1;
                    string fighterChoice = "initialize variable";
                    int fighetChoiceIdx = -1;
                    //we need to print out which fighters, unless thats already happened
                    string fighterChoice = Console.ReadLine();
                    //this looks like attempted 
                    while(!Int32.TryParse(fighterChoice, out fighetChoiceIdx || fighterChoice))
                    foreach(Human fighter in availableFighters)
                    {
                        System.Console.WriteLine(counter + " {0} - {1}", fighter.name, fighter.GetType().Name);
                        counter++;
                    }
                    //for each class, could have a list of actions strings
                    //action prompt and execute method
                    //current implimentation is to pass opponent bench to executeActon method, and have each class impliment it specific to their move set
                    //started with ninja
                    //I believe I have begun to generalize the method so that it doesn't need to be implimented specifically for each class
                    //I think i would need to create a move type attribute for each class action, so that a generic function can call them
                    //for instance attatcks require a target, heals heal self or friendly target, bench moves do bench swaps ect.

                }
            }
        }

    }

}