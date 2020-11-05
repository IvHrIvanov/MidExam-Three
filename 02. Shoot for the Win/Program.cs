using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                int shot = int.Parse(commands);

                if (shot < targets.Length)
                {
                    int currentTarge = targets[shot];
                    targets[shot] = -1;

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] != -1)
                        {
                            if (currentTarge < targets[i])
                            {
                                targets[i] -= currentTarge;

                            }
                            else if(currentTarge>=targets[i])
                            {
                                targets[i] += currentTarge;
                            }
                           
                        }

                    }

                }

                commands = Console.ReadLine();
            }

            int shotTargets = targets.Count(x => x == -1);

            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");
        }
    }
}