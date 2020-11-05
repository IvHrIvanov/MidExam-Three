using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(int.Parse)
                                                  .ToList();

            string[] comand = Console.ReadLine().Split(" ");

            while (comand[0] != "End")
            {

                int index = int.Parse(comand[1]);

                if (comand[0] == "Shoot")
                {
                    if (index < targets.Count && index >= 0)
                    {
                        int power = int.Parse(comand[2]);

                        targets[index] -= power;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }

                }
                else if (comand[0] == "Add")
                {

                    if (index < targets.Count && index >= 0)
                    {
                        int value = int.Parse(comand[2]);

                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (comand[0] == "Strike")
                {
                    int radius = int.Parse(comand[2]);

                    if (index + radius < targets.Count && index - radius >= 0)
                    {
                        targets.RemoveRange(index - radius, radius * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }

                }

                comand = Console.ReadLine().Split(" ");
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
