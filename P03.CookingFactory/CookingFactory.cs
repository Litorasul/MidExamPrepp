﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.CookingFactory
{
    class CookingFactory
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            List<int> bestBatch = new List<int>();
            int bestBatchElements = 0;
            int bestQuality = 0;
            int bestAverage = 0;





            while (input != "Bake It!")
            {


                List<int> curentBatch = input.Split("#").Select(int.Parse).ToList();
                int curentBatchElements = curentBatch.Count();
                int curentQuality = curentBatch.Sum();
                int curentAverage = 1;

                if (curentBatchElements != 0 && curentQuality != 0)
                {
                    curentAverage = curentQuality / curentBatchElements;
                }
                else
                {
                    curentAverage = 1;
                }

                if (curentQuality > bestQuality)
                {
                    bestBatch = curentBatch.ToList();
                }
                else if (curentQuality == bestQuality
                    && curentAverage > bestAverage)
                {
                    bestBatch = curentBatch.ToList();
                }
                else if (curentQuality == bestQuality
                    && curentAverage == bestAverage
                    && curentBatchElements < bestBatchElements)
                {
                    bestBatch = curentBatch.ToList();
                }

                bestBatchElements = bestBatch.Count();
                bestQuality = bestBatch.Sum();
                if (bestQuality != 0 && bestBatchElements != 0)
                {
                    bestAverage = bestQuality / bestBatchElements;
                }
                else
                {
                    bestAverage = 0;
                }


                input = Console.ReadLine();


            }

            Console.WriteLine($"Best Batch quality: {bestQuality}");
            Console.WriteLine(string.Join(" ", bestBatch));
        }
    }
}
