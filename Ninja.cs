namespace oop_game
{
    //inherets from human so targets can be of any type
    public class Ninja: Human
    {
        //constructor
        public Ninja(string inputName): base(inputName)
        {
            dexterity = 175;
            System.Console.WriteLine("I am Ninja.  I am called {0}. I will bring death from the shadows.", name);
            System.Console.WriteLine("*****************************************************************");
        }

        //attack - generic human attack plus self heal
        public void steal(Human target)
        {
            attack(target);
            health += 10;
            System.Console.WriteLine("{0} also stole some of {1}'s valuables and gained 10 health.  {0} now has {2} heatlh.", name, target.name, health);
            System.Console.WriteLine("*****************************************************************");
        }

        //escape move, not sure what purpose will be yet
        public void getAway()
        {
            health -= 15;
            System.Console.WriteLine("{0} ran away, barely escaping alive.  {0} now has {1} health.", name, health);
            System.Console.WriteLine("*****************************************************************");
        }
    }
}