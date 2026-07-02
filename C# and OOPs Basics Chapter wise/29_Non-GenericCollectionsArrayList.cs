/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _29_Non_GenericCollectionsArrayList
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Creating an ArrayList
                ArrayList list = new ArrayList();

                // Adding different types of elements (Not Type-Safe)
                list.Add(10);          // Integer
                list.Add("Hello");     // String
                list.Add(2.5);         // Double

                Console.WriteLine("--- ArrayList Elements ---");
                // Displaying elements using a foreach loop
                foreach (object item in list)
                {
                    Console.WriteLine(item);
                }

                // Accessing elements via index (Requires explicit casting for operations)
                int firstElement = (int)list[0];
                Console.WriteLine($"\nFirst Element casted back to int: {firstElement}");

                // Keeps console window open
                Console.ReadLine();
            }
        }
    }
}


 */