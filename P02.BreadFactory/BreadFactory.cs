using System;
using System.Linq;

namespace P02.BreadFactory
{
    class BreadFactory
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|").ToArray();
            int energy = 100;
            int coins = 100;

            for (int i = 0; i < input.Length; i++)
            {
                string[] events = input[i].Split("-").ToArray();
                string eventName = events[0];
                int eventPower = int.Parse(events[1]);

                if (eventName == "rest")
                {
                    int energyTemp = energy + eventPower;
                    if (energyTemp < 100)
                    {
                        energy = energyTemp;
                        Console.WriteLine($"You gained {eventPower} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                    else
                    {
                        energy = 100;
                        int healedFor = eventPower - (energyTemp - 100);
                        Console.WriteLine($"You gained {healedFor} energy.");
                        Console.WriteLine($"Current energy: {energy}.");

                    }
                }
                else if (eventName == "order")
                {
                    energy -= 30;
                    if (energy >= 0)
                    {                   
                        coins += eventPower;
                        Console.WriteLine($"You earned {eventPower} coins.");
                    }
                    else
                    {
                        energy += 50;
                        Console.WriteLine("You had to rest!");
                    }

                }
                else
                {
                    coins -= eventPower;
                    if (coins >= 0)
                    {
                        Console.WriteLine($"You bought {eventName}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {eventName}.");
                        break;
                    }
                }
            }

            if (coins >= 0)
            {
                Console.WriteLine("Day completed!"
                    + Environment.NewLine + $"Coins: {coins}"
                    + Environment.NewLine + $"Energy: {energy}");
            }
        }
    }
}
