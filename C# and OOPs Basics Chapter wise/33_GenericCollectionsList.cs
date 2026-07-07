/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _33_GenericCollectionsList
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Creating a type-safe list that strictly holds integers
                List<int> numbers = new List<int>();

                // Adding elements
                numbers.Add(10);
                numbers.Add(20);
                numbers.Add(30);
                // numbers.Add("Hello"); // ❌ Compile Error! Prevents accidental mixed-type inputs

                Console.WriteLine("--- List<int> Elements ---");
                foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }

                // Removing an element by value
                numbers.Remove(20);
                Console.WriteLine($"\nTotal elements left after removal: {numbers.Count}");

                Console.ReadLine();
            }
        }
    }
}
*/