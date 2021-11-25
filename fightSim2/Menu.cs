using System;
using System.Collections.Generic;

namespace fightSim2
{
    public class Menu
    {

        private List<string> menuOptions = new List<string>() { "\n1) Create your fighter", "\n2) Create enemy fighter", "\n3) fight" };

        public void StartMenu()
        {
            int option = 0;
            while (option == 0)
            {

                Console.WriteLine("Welome to FightSim 2.0!\nType the number of action and press ENTER:" + menuOptions[0] + menuOptions[1] + menuOptions[2]);

                while (!int.TryParse(Console.ReadLine(), out option) && option < menuOptions.Count || option > menuOptions.Count)
                {

                    Console.WriteLine("Please enter a valid number");

                }

                if (option == 1)
                {
                    Fighter.AddPlayerFighter();
                    Console.Clear();
                    Fighter.activeFighters[0].GiveName();

                }
                else if (option == 2)
                {
                    Fighter.AddEnemyFighter();
                    Console.Clear();
                    Fighter.activeFighters[1].GiveName();

                }
                else if (option == 3)
                {

                }

            }
        }
    }
}