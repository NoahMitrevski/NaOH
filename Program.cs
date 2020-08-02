using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int LevelUpHKnight = 5;
            int HpKnight = 75;
            int levelUpD = 1;
            int swordD = 2;
            int slimeHp = 10;
            Console.WriteLine("Choose Your Character!");
            Console.WriteLine("knight");
            string story = Console.ReadLine();

            if (story == "knight")
            {
                Console.WriteLine("Please state your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hello Knight " + name);

                Console.WriteLine("Where would you like to go?");
                Console.WriteLine("Path to Bridgend");
                string destination = Console.ReadLine();
                if (destination == "Path to Bridgend")
                {
                    Console.WriteLine("You are headed to Bridgend!");
                    int encounter = 1;
                    if (encounter == 1)
                    {
                        Monster slime = new Monster(1, 10, 2, 1);
                        Console.WriteLine("You have encountered a slime!");
                        Console.WriteLine(HpKnight + " Your Hp");
                        Console.WriteLine("The Slime HP is 10");

                        while (slimeHp != 0 && HpKnight != 0)
                        {
                            Console.Write("Would you like to attack or run?: ");
                            string choice1 = Console.ReadLine();
                            if (choice1 == "attack")
                            {
                                Console.WriteLine(HpKnight - swordD + " You took " + swordD);
                                Console.WriteLine(slimeHp - swordD + " The Slimes new HP");
                                slimeHp = slimeHp - swordD;
                                HpKnight = HpKnight - swordD;
                            }
                            else if (choice1 == "run") ;
                            {
                            }

                            if (slimeHp == 0)
                            {
                                Console.WriteLine("Congradulations you have murdered the slime!!!");
                            }

                        }
                    }
                }

            }
        }
    }
}