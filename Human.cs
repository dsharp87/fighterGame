using System.Collections.Generic;

namespace oop_game {

    //this is the parent class of all fighters so that methods have a commont type to target
    //human is abstract, and never meant to actually be created as a fighter type
    public abstract class Human {
        public string name;
        public int intelligence = 3;
        public int strength = 3;
        public int dexterity = 3;
        public int health = 100;
        public bool isAlive = true;
        public bool hasActed = false;
        public Human(string nameInput) 
        {
            name = nameInput;
        }
        //think about how to impliment action list
        public List<string> actionList;

        //constuctor
        public Human(string nameInput, int intel, int str, int dex, int hp)
        {
            name = nameInput;
            intelligence = intel;
            strength = str;
            dexterity = dex;
            health = hp;
        }


        //generic attack method that accepts humans
        //does dmg to health and writes outcome of fight
        public void attack(Human target)
        {
            if(target is Human)
            {
                Human attackTarget = target as Human;
                attackTarget.health -= 5*strength;
                System.Console.WriteLine("{0} attacked {1} for {2} dmg and {1} now has {3} health!", name, attackTarget.name, 5*strength, attackTarget.health);
                System.Console.WriteLine("*****************************************************************");
            }
        }

        //this will print out a combatants type and stats
        public void displayStatus()
        {
            System.Console.WriteLine("I am a {0} named {1}. My stats are as follows:", this.GetType().Name, name);
            System.Console.WriteLine("Current health = {0}", health);
            System.Console.WriteLine("Intelligence = {0}", intelligence);
            System.Console.WriteLine("Strength = {0}", strength);
            System.Console.WriteLine("Dexterity = {0}", dexterity);
            System.Console.WriteLine("*****************************************************************");            
        }

        public void displayActions()
        {
            foreach(string actionName in actionList)
            {

            }
        }
    }
}