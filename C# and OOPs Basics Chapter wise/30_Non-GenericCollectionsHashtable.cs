/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _30_Non_GenericCollectionsHashtable
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Creating a Hashtable
                Hashtable table = new Hashtable();

                // Adding Key-Value pairs (Key, Value)
                table.Add("ID", 507);
                table.Add("Name", "John");
                table.Add("Role", "Student");

                Console.WriteLine("--- Hashtable Elements ---");
                // Displaying items using DictionaryEntry
                foreach (DictionaryEntry item in table)
                {
                    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
                }

                // Accessing a specific value directly using its key
                Console.WriteLine($"\nAccessing Name directly: {table["Name"]}");

                Console.ReadLine();
            }
        }
    }

}

 */