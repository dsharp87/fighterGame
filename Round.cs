namespace oop_game 
{
    public class Round
    {
        //relativly simple object that allows turns to be nested, this is so that in the future more than 2 players could have turns
        public Round(Player p1, Player p2)
        {
            System.Console.WriteLine("*****************************************************************");
            System.Console.WriteLine("NEW ROUND!");
            new Turn(p1, p2);
            new Turn(p2, p1);
        }

    }
}