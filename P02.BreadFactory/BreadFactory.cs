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
                    int currentEnergy = energy;
                    energy += eventPower;

                    if (energy > 100)
                    {
                        
                        Console.WriteLine($"You gained {100 - currentEnergy} energy.");
                        Console.WriteLine($"Current energy: 100.");
                        energy = 100;
                    }
                    else
                    {
                        
                        Console.WriteLine($"You gained {eventPower} energy.");
                        Console.WriteLine($"Current energy: {energy}.");

                    }
                }
                else if (eventName == "order")
                {
                   
                    if (energy >= 30)
                    {                   
                        coins += eventPower;
                        Console.WriteLine($"You earned {eventPower} coins.");
                        energy -= 30;
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
                    if (coins > 0)
                    {
                        Console.WriteLine($"You bought {eventName}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {eventName}.");
                        return;
                    }
                }
            }



            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
           
        }
    }
}
