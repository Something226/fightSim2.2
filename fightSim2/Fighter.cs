using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;

namespace fightSim2
{
    public class Fighter
    {
        //variables for Fighter class
        private Random number;

        private List<string> enemyNames;
        
        private int hp;
        private int strength;
        private int xp;
        private string name;

        private bool isAlive;

        public Weapon weapon = new Weapon();

        //Fighter Constructor
        public Fighter()
        {
            enemyNames = new List<string>() { "Arnold", "Script Kid", "Mikael Bergström", "Crewmate", "Walter White" };

            number = new Random();

            hp = 100;
            strength = 2;
            isAlive = true;

        }

        //method that lets user name fighter
        public void GiveName()
        {
            bool named = false;

            while (named != true)
            {
                Console.WriteLine("Name Your Fighter:");

                name = "";
                while (name == "")
                {
                    name = Console.ReadLine().Trim();

                    if (name == "")
                    {
                        Console.WriteLine("Enter a name");
                    }

                }
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

        //gives a random name
        public void GiveRandomName()
        {
            name = enemyNames[number.Next(enemyNames.Count)];
        }

        //attack-method, attacks selected target
        public void Attack(Fighter target)
        {
            target.hp -= strength + weapon.Damage() / 2;

            if (target.hp <= 0)
            {
                target.hp = 0;

                target.isAlive = false;
            }
        }

        //returns isAlive
        public bool GetAlive()
        {
            return isAlive;
        }

        //returns name
        public string GetName()
        {
            return name;
        }

        //returns hp
        public int GetHP()
        {
            return hp;
        }

    }
}