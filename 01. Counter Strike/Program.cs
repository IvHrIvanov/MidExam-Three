using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {

            int energy = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int winBattle = 0;
            bool flag = false;
            while (input != "End of battle")
            {
                int distance = int.Parse(input);

                if (energy < distance)
                {
                    
                    Console.WriteLine($"Not enough energy! Game ends with {winBattle} won battles and {energy} energy");
                    flag = true;
                    break;

                }

                energy -= distance;

                winBattle++;

                if (winBattle % 3 == 0)
                {
                    energy += winBattle;
                }
                input = Console.ReadLine();

                if (flag)
                {
                    break;
                }


            }
            if (!flag)
            {
                Console.WriteLine($"Won battles: {winBattle}. Energy left: {energy}");
            }
        }
    }
}