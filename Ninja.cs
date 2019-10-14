using System;
using System.Collections.Generic;

namespace oop_game
{
    //inherets from human so targets can be of any type
    public class Ninja: Human
    {
        public List<string> ActionList = new List<string>{"Steal - attack + small self heal.", "Get Away - make hasty retreat and swap places with a benched hero without using action count"};
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
        //perhaps an auto bench swap that doesn't use up action for turn
        //NEEDS BENCH TARGET AS INPUT PARAMETER
        public void getAway()
        {
            health -= 15;
            //BENCH SWAP FUNCTIONALITY HERE
            System.Console.WriteLine("{0} ran away, barely escaping alive.  {0} now has {1} health.", name, health);
            System.Console.WriteLine("*****************************************************************");
        }

        //
        public void ExecuteAction(List<Human> targets)
        {
            string actionChoice = "variable initiation";
            int actionChoiceIdx;
            while(!Int32.TryParse(actionChoice, out actionChoiceIdx) || actionChoiceIdx < 0 || actionChoiceIdx >= actionList.Count )
            {
                System.Console.WriteLine("{0}'s actions are:", name);
                int actionIdx = 0;
                foreach(string action in actionList)
                {
                    System.Console.WriteLine(actionIdx + 1 + " - {0}", action);
                    actionIdx++;
                }
                System.Console.WriteLine("What do you choose?");
                actionChoice = Console.ReadLine();  
            }
            
            
            while(actionChoice !=  "1" || actionChoice != "2")
            {
                System.Console.WriteLine("Please enter the number coresponding to the action you would like to take.");
                System.Console.WriteLine("{0}'s actions are:", name);
                for(int i = 1; i <= actionList.Count; i++)
                {
                    System.Console.WriteLine(i + 1 + " - " + actionList[i]);
                }
                actionChoice = Console.ReadLine();
                System.Console.WriteLine("What do you choose?");
            }
            //attack choice
            if(actionChoice == "1")
            {
                string targetchoice = "variable initiation";
                int choiceIdx = -1;
                while(!Int32.TryParse(targetchoice, out choiceIdx) || choiceIdx < 1 || choiceIdx >= targets.Count + 1)
                    {
                    int targetidx = 0;
                    System.Console.WriteLine("What fighter do you want to target?");
                    foreach(Human target in targets)
                    {
                        System.Console.WriteLine(targetidx + 1 + " - {0} || {1} || {2} health remaining",target.name , target.GetType().Name, target.health );
                        targetidx++;
                    }
                    targetchoice = Console.ReadLine();
                    if(!Int32.TryParse(targetchoice, out choiceIdx ) || choiceIdx < 1 || choiceIdx >= targets.Count + 1)
                    {
                        System.Console.WriteLine("Please chose the number corresponding to the fighter you wish to target");
                        continue;
                    }
                    choiceIdx = Int32.Parse(targetchoice);
                }
                steal(targets[choiceIdx - 1]);
                hasActed = true;
            }
            
        }
    }
}