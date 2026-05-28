using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class StaticConstructor_05
    {
        class Company
        {
            public static string companyName;
            static Company()
            {
                companyName = "BhaiJan Corporation";
                Console.WriteLine("Static Constructor Called");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Company Name: " + Company.companyName);
            }
        }
    }
}
