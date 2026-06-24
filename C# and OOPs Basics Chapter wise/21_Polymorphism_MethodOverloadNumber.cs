
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _21_Polymorphism_MethodOverloadNumber 
    {
        class Program
        {
            // 1. Method with ONE integer parameter
            void display(int a)
            {
                Console.WriteLine("Arguments: " + a);
            }

            // 2. Overloaded method with TWO integer parameters
            void display(int a, int b)
            {
                Console.WriteLine("Arguments: " + a + " and " + b);
            }

            static void Main(string[] args)
            {
                // Creating class object to call instance methods
                Program p1 = new Program();

                // Calls the 1st method (takes 1 argument)
                p1.display(100);

                // Calls the 2nd method (takes 2 arguments)
                p1.display(100, 200);

                // Holds the console screen open
                Console.ReadLine();
            }
        }
    }
}

