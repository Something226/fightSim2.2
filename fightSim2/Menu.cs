using System;
using System.Collections.Generic;

namespace fightSim2
{
    public class Menu
    {

        public List<string> menuOptions = new List<string>() { "\n1) Create Player Fighter", "\n2) Create Enemy Fighter", "\n3) List All Fighters", "\n4) Select Fighter", "\n5) Quit Game" };

        public void StartMenu()
        {
            int option = 0;
            while (option == 0)
            {

                Console.WriteLine("Type the number of action and press ENTER:" + menuOptions[0] + menuOptions[1] + menuOptions[2] + menuOptions[3] + menuOptions[4]);

                while (!int.TryParse(Console.ReadLine(), out option) && option < menuOptions.Count || option > menuOptions.Count)
                {

                    Console.WriteLine("Please enter a valid number");

                }

                if (option == 1)
                {
                    Fighter.AddPlayerFighter();
                    Console.Clear();
                    Console.WriteLine("New Player Fighter Created!\n");

                    StartMenu();

                }
                else if (option == 2)
                {
                    Fighter.AddEnemyFighter();
                    Console.Clear();
                    Console.WriteLine("New Enemy Fighter Created!\n");

                    StartMenu();

                }
                else if (option == 3)
                {
                    Console.Clear();
                    Fighter.ListFighter();
                    Console.WriteLine("\n");

                    StartMenu();
                }
                else if (option == 4)
                {
                    Console.Clear();
                    StartMenu();
                }
                else if (option == 5)
                {

                }

            }
        }
    }
}