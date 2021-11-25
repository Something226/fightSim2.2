using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;

namespace fightSim2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            FightSequence fightSequence = new FightSequence();

            Console.WriteLine("hellooo");

            Console.ReadLine();

            menu.StartMenu();

            Console.ReadLine();



        }
    }
}
