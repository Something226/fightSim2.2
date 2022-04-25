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

        Weapon weapon = new Weapon();

        //List with a set of names that will potentially be used to randomize enemyFighter name
        protected List<string> enemyNames = new List<string>() { "Arnold", "Script Kid", "Mikael Bergström", "Crewmate", "Walter White" };

        protected int hp;
        protected int strength;
        protected int dmgAmount;

        protected string name;

        protected bool isAlive;
        protected bool isEnemy;

        public static List<Fighter> activeFighters = new List<Fighter>();
        public static Queue<Fighter> queueFighter = new Queue<Fighter>();

        //Fighter Constructor, determines variables
        public Fighter()
        {
            number = new Random();

            isAlive = true;

        }

        //method that lets user name fighter
        /* bool named returns true if GiveName is finished, when name is given player is prompted to accept name, if name is not accepted named = false */
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

        //attack-method, attacks selected target, uses weapon class to deal dmg
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
        /* Finds index where fighter is ocated in activeFighters, if no correlating index is found no fighter gets removed */
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

        //Method that is used to select two fighters for fightSequence
        /*  */
        public static void SelectFighter(string name)
        {

            int selectedAmount = 0;

            while (activeFighters.Count > 0 && selectedAmount < 2)
            {
                if (selectedAmount == 0)
                {
                    Console.WriteLine("Select Player Fighter!");
                }
                else
                {
                    Console.WriteLine("Select Enemy Fighter!");
                }

                int i = activeFighters.FindIndex(0, 1, f => f.name == name);

                if (i >= 0)
                {
                    Console.WriteLine("Fighter selected successfully!\n");
                    System.Console.WriteLine(i);
                    Console.ReadLine();

                    selectedAmount++;
                }
                else
                {
                    Console.WriteLine("No fighter with that name exists\n");
                }
            }
        }

        //Lists all current fighters
        /* Lists fighters from activeFighters if Fighter-instances exists, includes differing between enemy and player, amount of fighters will also be displayed, 
            fighterType defines which fighter type will be listed, fighterType 1 = Player Fighter, fighterType 2 = Enemy Fighter, fighterType 3 = All Fighters*/
        public static void ListFighter(int fighterType)
        {
            if (activeFighters.Count == 0)
            {
                Console.WriteLine("There are no fighters at the moment");
            }
            else
            {
                Console.WriteLine($"Number of fighters: {activeFighters.Count}");

                activeFighters.Sort((a, b) => a.GetType().FullName.CompareTo(b.GetType().FullName));

                activeFighters.Reverse();

                foreach (Fighter fighter in activeFighters)
                {
                    if (fighter is PlayerFighter && fighterType == 1)
                    {
                        Console.WriteLine(fighter.name + " / Player Fighter");
                    }
                    else if (fighter is EnemyFighter && fighterType == 2)
                    {
                        Console.WriteLine(fighter.name + " / Enemy Fighter");
                    }
                    else if (fighter is PlayerFighter && fighterType == 3)
                    {
                        Console.WriteLine(fighter.name + " / Player Fighter");
                    }
                    else if (fighter is EnemyFighter && fighterType == 3)
                    {
                        Console.WriteLine(fighter.name + " / Enemy Fighter");
                    }
                }

            }
        }
    }
}