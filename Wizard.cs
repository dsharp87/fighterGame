using System;

namespace oop_game 
{

    public class Wizard: Human
    {

        //constructor = inherits from human for gernic typing
        public Wizard(string inputName): base(inputName)
        {
            intelligence = 25;
            health = 50;
            System.Console.WriteLine("I am Wizard.  I am called {0}. My magic is superior.", name);
            System.Console.WriteLine("*****************************************************************");
        }

        //heal - allows other or self targeting
        public void heal(Human target)
        {
            target.health += 10*intelligence;
            if(target != this)
            {
                System.Console.WriteLine("{0} casts heal on {1} and {1} is healed for {2} health. {1} now has {3} health.", name, target.name, 10*intelligence, target.health);
            }
            else
            {
                System.Console.WriteLine("{0} casts heal on themself and is healed for {1}.  {0} now has {2} health", name, 10*intelligence, health);
            }
            System.Console.WriteLine("*****************************************************************");
        }

        //attack - does random amount of dmg to target
        public void fireBall(Human target)
        {
            Random rand = new Random();
            int dmg = rand.Next(20, 51);
            target.health -= dmg;
            System.Console.WriteLine("{0} casts Fireball at {1}.  It does {2} damage leaving {1} at {3} health.", name, target.name, dmg, target.health);
            System.Console.WriteLine("*****************************************************************");
        }
    }

}
