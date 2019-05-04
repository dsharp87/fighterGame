namespace oop_game
{
    //this is the master object that will instantiate and manage all resulting aspects of the game 
    public class Game
    {
        public Player p1;
        public Player p2;
        public int roundCount;


        //constructor, creates new players and begins a round, at the end of each round it checks to see if a player is dead, if so, it ends the game
        //will eventually add a 'play again' funtionatlity
        public Game()
        {
            p1 = new Player();
            p2 = new Player();
            roundCount = 0;
            System.Console.WriteLine("FIGHT!");
            while (!EndCheck())
            {
               new Round(p1, p2);
            }
            if(!p1.isAlive)
            {
                System.Console.WriteLine("{0} has vanquished {1}'s team and is VICTORIOUS!", p1.playerName, p2.playerName);
            }
            else if(!p2.isAlive)
            {
                System.Console.WriteLine("{0} has vanquished {1}'s team and is VICTORIOUS!", p1.playerName, p2.playerName);
            }
        }

        //method goes through each players roster, and if it finds an alive combatant, sets player to alive, which will result in the method returning 'negative game end condition'
        public bool EndCheck() 
        {
            p1.isAlive = false;
            p2.isAlive = false;
            foreach(Human combatant in p1.roster)
            {
                if(combatant.isAlive == true)
                {
                    p1.isAlive = true;
                    break;
                }
            }
            foreach(Human combatant in p2.roster)
            {
                if(combatant.isAlive == true)
                {
                    p2.isAlive = true;
                    break;
                }
            }
            if (p1.isAlive && p2.isAlive)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}