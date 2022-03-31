using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;

namespace fightSim2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu instance is created
            Menu menu = new Menu();
            //Fightsequence is created for future fights
            FightSequence fightSequence = new FightSequence();
            //Initial message player sees
            Console.WriteLine("Welome to FightSim 2.0!\n");
            //Menu StartMenu-method is ran here
            menu.StartMenu();

        }
    }
}
