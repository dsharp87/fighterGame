namespace oop_game
{
    public class Samurai: Human
    {
        //global sammuri counter
        public static int samuraiCount = 0;
        public int maxHealth = 200;

        //constructor, inherits from human for generic typing
        public Samurai(string inputName): base(inputName)
        {
            health = 200; 
            samuraiCount += 1;
            System.Console.WriteLine("I am Samuri.  I am called {0}. Honor and glory.", name);
            System.Console.WriteLine("*****************************************************************");
        }

        //attack - if targets life below threhold, it kills, otherwise no effect
        public void deathBlow(Human target)
        {
            if(target.health <= 50)
            {
                target.health = 0;
                System.Console.WriteLine("{0} cuts down {1} with a single massive slash! {1} lies dead.", name, target.name);
                System.Console.WriteLine("*****************************************************************");
            }
            else
            {
                System.Console.WriteLine("{0}'s will is strong, and is able to withstand {1}'s death blow.  The battle continues.", target.name, name);
                System.Console.WriteLine("*****************************************************************");
            }
        }

        //heal - full heal
        public void meditate()
        {
            health = maxHealth;
            System.Console.WriteLine("{0} sits down and enters a meditative trance. When the Samuri rises, he is surrounded by a visible glow, and it is clear his vitality has been restored.", name);
            System.Console.WriteLine("*****************************************************************");
        }

        //prints how may samurii exist globally
        public void howMany()
        {
            System.Console.WriteLine("We are many. I currently there are {0} Samuri among us.", samuraiCount);
            System.Console.WriteLine("*****************************************************************");
        }
    }
}
