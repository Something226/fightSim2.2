using System;

namespace fightSim2
{
    public class Fighter
    {
        private int hp = 100;

        public string name;

        public bool isAlive = true;

        public Weapon weapon = new Weapon();

        public int strength = 4;

        public void GiveName()
        {
            bool named = false;

            while (named != true)
            {
                Console.WriteLine("\nName Fighter:");
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

        public void Attack(Fighter target)
        {
            target.hp -= strength + weapon.Damage();
        }

        public bool IsAlive()
        {
            return isAlive;
        }

    }
}