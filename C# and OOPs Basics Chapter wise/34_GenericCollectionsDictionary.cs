/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _34_GenericCollectionsDictionary
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Key must be string, Value must be int
                Dictionary<string, int> studentAges = new Dictionary<string, int>();

                studentAges.Add("Alice", 21);
                studentAges.Add("Bob", 22);

                Console.WriteLine("--- Dictionary Elements ---");
                // Iterating over KeyValuePair elements safely
                foreach (KeyValuePair<string, int> kvp in studentAges)
                {
                    Console.WriteLine($"Student: {kvp.Key}, Age: {kvp.Value}");
                }

                Console.ReadLine();
            }
        }
    }
}
 */