using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _23_PolymorphismMethodOverloadingbyChangingParameterOrder
    {
        class Program
        {
            // 1. Order: Int first, then String
            void display(int a, string b)
            {
                Console.WriteLine("int: " + a);
                Console.WriteLine("string: " + b);
            }

            // 2. Order: String first, then Int
            void display(string b, int a)
            {
                Console.WriteLine("string: " + b);
                Console.WriteLine("int: " + a);
            }

            static void Main(string[] args)
            {
                Program p1 = new Program();

                Console.WriteLine("--- Calling First Mix ---");
                // Matches method 1 (int, string)
                p1.display(100, "Programming");

                Console.WriteLine("\n--- Calling Second Mix ---");
                // Matches method 2 (string, int)
                p1.display("Programiz", 400);

                // Holds the console screen open
                Console.ReadLine();
            }
        }
    }
}

