using System;
using System.Collections.Generic;

namespace oop_game
{
    //players contain the list of fighters in a roster
    public class Player
    {
        public string playerName;
        public List<Human> roster;

        //active roster

        //bench

        public bool isAlive = true;

        public Player()
        {
            System.Console.WriteLine("Greetings Player. What name do you want to be called?");
            string input = Console.ReadLine();
            playerName = input;

            //this could be turned into its own method most likely
            roster = new List<Human>();
            System.Console.WriteLine("You must select your roster of 4 combatants.");
            while(roster.Count < 4)
            {
                System.Console.WriteLine("Please select the type of combatant for combatant number {0}. \r\n 1 - Ninja \r\n 2 - Samurai \r\n 3 - Wizard", roster.Count+1);
                System.Console.WriteLine("--------------------------------");
                string typeInput = Console.ReadLine();
                if(typeInput == "1" || typeInput == "2" || typeInput == "3")
                {
                    System.Console.WriteLine("Please name your combatant");
                    string nameInput = Console.ReadLine();
                    if(typeInput == "1")
                    {
                        roster.Add(new Ninja(nameInput));
                    }
                    if(typeInput == "2")
                    {
                        roster.Add(new Samurai(nameInput));
                    }
                    if(typeInput == "3")
                    {
                        roster.Add(new Wizard(nameInput));
                    }
                }
                else
                {
                    System.Console.WriteLine("Please choose 1, 2 or 3 to select combatant type.");
                }
            }
            DisplayRoster();
        }


        //iterates through list of fighters and calls the display staus method for it
        public void DisplayRoster()
        {
            System.Console.WriteLine("{0}'s Team Status", playerName);
            System.Console.WriteLine("--------------------------------");
            foreach(Human combatant in roster)
            {
                combatant.displayStatus();
            }
        }

    }
}