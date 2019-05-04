using System;

namespace oop_game
{
    class Program
    {
        static void Main(string[] args)
        {

            Wizard w1 = new Wizard("james");
            System.Console.WriteLine(w1.GetType().Name);
            //starts a new game
            Game fightGame = new Game();
        }
    }
}
