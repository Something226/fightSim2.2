using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;

namespace fightSim2
{
    public class Fighter
    {
        //variables for Fighter class
        private Random generator = new Random();

        private List<string> enemyNames = new List<string>() { "Arnold", "Script Kid", "Mikael Bergström", "Crewmate", "Walter White" };

        private int hp = 100;
        private int strength = 2;

        private string name;

        private bool isAlive = true;

        public Weapon weapon = new Weapon();

        /*public Fighter()
        {

        }*/

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
            int select = generator.Next(enemyNames.Count);

            name = enemyNames[select];

        }

        //attack-method, attacks selected target
        public void Attack(Fighter target)
        {
            target.hp -= strength + weapon.Damage();

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