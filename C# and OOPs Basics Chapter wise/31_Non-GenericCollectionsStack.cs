/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _31_Non_GenericCollectionsStack
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Creating a Stack
                Stack stack = new Stack();

                // Push element onto the top of the stack
                stack.Push("First Item");
                stack.Push(200);
                stack.Push("Top Item");

                Console.WriteLine("--- Stack Elements ---");
                foreach (object item in stack)
                {
                    Console.WriteLine(item); // Prints from top to bottom
                }

                // Peek looks at the top item without removing it
                Console.WriteLine($"\nTop element (Peek): {stack.Peek()}");

                // Pop removes and returns the top element
                Console.WriteLine($"Removed item (Pop): {stack.Pop()}");
                Console.WriteLine($"New top element (Peek): {stack.Peek()}");

                Console.ReadLine();
            }
        }
    }
}
 */