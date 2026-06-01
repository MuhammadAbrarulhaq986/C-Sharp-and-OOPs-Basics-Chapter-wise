/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class Encapsulation_07
    {
        public class CoffeeMachine
        {
            // Private fields (Data Hiding)
            private int waterAmount; // in milliliters
            private int beansAmount; // in grams
            private bool isHeated;

            // Public Constructor
            public CoffeeMachine(int water, int beans)
            {
                waterAmount = water;
                beansAmount = beans;
                isHeated = false;
            }

            // Private internal methods (Implementation Hiding)
            private void HeatWater()
            {
                if (!isHeated)
                {
                    Console.WriteLine("Heating water...");
                    isHeated = true;
                }
            }

            private void GrindBeans(int amount)
            {
                if (beansAmount < amount)
                {
                    throw new InvalidOperationException("Not enough coffee beans!");
                }
                Console.WriteLine("Grinding coffee beans...");
                beansAmount -= amount;
            }

            // Public methods exposed to the user (Interface)
            public void MakeEspresso()
            {
                HeatWater();
                GrindBeans(20); // Uses 20 grams of beans for an espresso
                Console.WriteLine("Making Espresso...");
            }

            public void MakeLatte()
            {
                HeatWater();
                GrindBeans(25); // Uses 25 grams of beans for a latte
                Console.WriteLine("Making Latte...");
            }

            public int BeansLeft()
            {
                return beansAmount;
            }

            public int WaterLeft()
            {
                return waterAmount;
            }
        }

        // Testing Encapsulation Principle
        public class Program
        {
            static void Main(string[] args)
            {
                // Initialize with 1000 ml of water and 100 grams of beans
                CoffeeMachine myMachine = new CoffeeMachine(1000, 100);

                // Outputs: Heating water... Grinding coffee beans... Making Espresso...
                myMachine.MakeEspresso();

                // Outputs: Beans left: 80 grams
                Console.WriteLine($"Beans left: {myMachine.BeansLeft()} grams");

                // Keeps the console window open
                Console.ReadLine();
            }
        }
    }
}

 */