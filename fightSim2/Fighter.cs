using System.Collections.Generic;
using System;

namespace fightSim2
{
    public class Fighter
    {
        public Random generator = new Random();

        public List<string> enemyNames = new List<string>() { "Arnold", "Script Kid", "Mikael Bergström", "Crewmate", "Walter White" };

        public int hp = 100;

        public string name;

        public bool isAlive = true;

        public Weapon weapon = new Weapon();

        public int strength = 8;

        public Fighter()
        {

        }

        public void GiveName()
        {
            bool named = false;

            while (named != true)
            {
                Console.WriteLine("Name Your Fighter:");
                name = Console.ReadLine();

                string answer = "";
                while (answer != "y" && answer != "n")
                {
                    Console.WriteLine("\nYour selected name is: " + name + ", correct?\ny/n");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();

                    if (answer != "y" && answer != "n")
                    {
                        Console.WriteLine("\nPlease enter a valid answer (y/n)\n");

                    }
                }

                if (answer == "y")
                {
                    named = true;
                }

            }
        }

        public void GiveRandomName()
        {
            int select = generator.Next(enemyNames.Count);

            name = enemyNames[select];

        }

        public void Attack(Fighter target)
        {
            target.hp -= strength + weapon.Damage();

            if (target.hp <= 0)
            {
                target.hp = 0;

                target.isAlive = false;
            }
        }

        public bool IsAlive()
        {
            return isAlive;
        }

    }
}