using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _22_PolymorphismMethodOverloadingbyChangingDataTypes
    {
        class Program
        {
            // 1. Method that accepts an Int type
            void display(int a)
            {
                Console.WriteLine("int type: " + a);
            }

            // 2. Overloaded method that accepts a String type instead
            void display(string b)
            {
                Console.WriteLine("string type: " + b);
            }

            static void Main(string[] args)
            {
                Program p1 = new Program();

                // Invokes the integer version of display
                p1.display(100);

                // Invokes the string version of display
                p1.display("Programiz");

                // Holds the console screen open
                Console.ReadLine();
            }
        }
    }
}

