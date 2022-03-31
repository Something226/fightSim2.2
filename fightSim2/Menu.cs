using System;
using System.Collections.Generic;

namespace fightSim2
{
    public class Menu
    {
        //String-List, Lists all available options that player has, options is used in StartMenu-method
        public List<string> menuOptions = new List<string>() { "\n1) Create Player Fighter", "\n2) Create Enemy Fighter", "\n3) List All Fighters", "\n4) Select Fighter", "\n5) Remove Fighter", "\n6) Quit Game" };

        //Menu method, Gives player options to choose from depending on desired action
        public void StartMenu()
        {
            bool runMenu = true;
            while (runMenu)
            {

                Console.WriteLine("Type the number of action and press ENTER:" + menuOptions[0] + menuOptions[1] + menuOptions[2] + menuOptions[3] + menuOptions[4] + menuOptions[5]);

                int option;

                while (!int.TryParse(Console.ReadLine(), out option) || (option < 1 || option > menuOptions.Count))
                {

                    Console.WriteLine("Please enter a valid number");

                }

                if (option == 1)
                {
                    Fighter.AddPlayerFighter();
                    Console.Clear();
                    Console.WriteLine("New Player Fighter Created!\n");

                }
                else if (option == 2)
                {
                    Fighter.AddEnemyFighter();
                    Console.Clear();
                    Console.WriteLine("New Enemy Fighter Created!\n");

                }
                else if (option == 3)
                {
                    Console.Clear();
                    Fighter.ListFighter();
                    Console.WriteLine("\n");

                }
                else if (option == 4)
                {
                    Console.Clear();
                }
                else if (option == 5)
                {
                    Console.Clear();
                    Fighter.ListFighter();

                    Console.WriteLine("\nPlease type the name of the fighter that you wish to remove\n");
                    Fighter.RemoveFighter(Console.ReadLine().Trim());

                }
                else if (option == 6)
                {
                    runMenu = false;
                }

            }
        }
    }
}