using System;
using System.Collections.Generic;

namespace PlatformGen
{
    class Program
    {
        static void Main(string[] args)
        {
            float inputX = float.Parse(args[0]);
            float inputY = float.Parse(args[1]);
            float offsetXMin = float.Parse(args[2]);
            float offsetYMin = float.Parse(args[3]);
            float offsetXMax = float.Parse(args[4]);
            float offsetYMax = float.Parse(args[5]);
            int toBeGen = int.Parse(args[6]);
            GeneratePlat(inputX, inputY, offsetXMin, offsetYMin, offsetXMax, offsetYMax, toBeGen);
        }
        static float RandomFL(float inputMin, float inputMax)
        {
            Random random = new Random();
            var next = random.NextDouble();
            double finalV = random.NextDouble() * (inputMax - inputMin) + inputMin;
            return (float)finalV;
        }
        static void GeneratePlat(float inputX, float inputY, float offsetXMin, float offsetYMin, float offsetXMax, float offsetYMax, int toBeGen)
        {
            for(int c = 0; c < toBeGen; c++)
            {
                float cordGenX = new float();
                cordGenX = RandomFL(offsetXMin, offsetXMax);
                float cordGenY = new float();
                cordGenY = RandomFL(offsetYMin, offsetYMax);
                var finalX = inputX + cordGenX;
                var finalY = inputY + cordGenY;
                Console.WriteLine("Coords = X: " + finalX + "; Y: " + finalY);
            }
        }
    }
}