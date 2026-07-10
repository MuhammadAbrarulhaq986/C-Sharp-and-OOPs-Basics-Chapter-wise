using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _37_CustomGenericImplementationsCreatingAGenericMethod
    {
        class Utility
        {
            // Generic method printing values of any type
            public void PrintDetails<T>(string label, T value)
            {
                Console.WriteLine($"{label}: {value}");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Utility util = new Utility();

                // Calling the method using an integer value
                util.PrintDetails<int>("Student Identity ID", 507);

                // Calling the method using a double value
                util.PrintDetails<double>("Calculated Gpa", 3.75);

                // Calling the method using a string value
                util.PrintDetails<string>("Department Code", "CS");

                Console.ReadLine();
            }
        }
    }
}