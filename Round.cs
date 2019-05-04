namespace oop_game 
{
    public class Round
    {

        public Round(Player p1, Player p2)
        {
            System.Console.WriteLine("*****************************************************************");
            System.Console.WriteLine("NEW ROUND!");
            new Turn(p1, p2);
            new Turn(p2, p1);
        }

    }
}