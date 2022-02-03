using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;
using System.Linq;

namespace fightSim2
{
    public class Fighter
    {
        /* Class description */
        /* Fighter class, template for all fighters in the game */

        //variables for Fighter class
        protected Random number;

        protected List<string> enemyNames = new List<string>() { "Arnold", "Script Kid", "Mikael Bergström", "Crewmate", "Walter White" };

        protected int hp;
        protected int strength;
        protected int dmgAmount;

        private int xp;
        protected string name;

        protected bool isAlive;
        protected bool isEnemy;

        public static List<Fighter> activeFighters = new List<Fighter>();

        protected Weapon weapon = new Weapon();

        //Fighter Constructor, determines variables
        public Fighter()
        {
            number = new Random();

            GiveName();

            isAlive = true;

        }

        //method that lets user name fighter
        public virtual void GiveName()
        {
            bool named = false;

            while (named != true)
            {
                if (isEnemy)
                {
                    Console.WriteLine("\nName Your Opponent:");
                }
                else
                {
                    Console.WriteLine("\nName Your Fighter:");
                }

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
            dmgAmount = strength + weapon.Damage();

            target.hp -= dmgAmount;

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

        //returns isEnemy
        public bool GetIsEnemy()
        {
            return isEnemy;
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

        //returns dmgAmount
        public int GetDmgAmount()
        {
            return dmgAmount;
        }

        //creates PlayerFighter instance
        public static void AddPlayerFighter()
        {
            activeFighters.Add(new PlayerFighter());
        }

        //creates EnemyFighter instance
        public static void AddEnemyFighter()
        {
            activeFighters.Add(new EnemyFighter());
        }

        //Removes Fighter instance
        public static void RemoveFighter(string name)
        {
            int i = activeFighters.FindIndex(0, 1, f => f.name == name);

            if (i >= 0)
            {
                activeFighters.RemoveAt(i);
                Console.WriteLine("Fighter removed successfully!\n");
            }
            else
            {
                Console.WriteLine("No fighter with that name exists\n");
            }
        }

        //Lists all current fighters
        public static void ListFighter()
        {
            Console.WriteLine($"Number of fighters: {activeFighters.Count}");
            foreach (Fighter fighter in activeFighters)
            {
                Console.WriteLine(fighter.name);
            }
        }
    }
}