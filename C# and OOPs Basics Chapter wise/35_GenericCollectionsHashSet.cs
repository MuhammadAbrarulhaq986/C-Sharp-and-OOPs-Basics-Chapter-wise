/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _35_GenericCollectionsHashSet
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Creating a HashSet of strings
                HashSet<string> uniqueNames = new HashSet<string>();

                uniqueNames.Add("Kamran");
                uniqueNames.Add("Zain");
                uniqueNames.Add("Zain"); // ⚠️ Duplicate item! This will be ignored automatically
                uniqueNames.Add("jan");
                uniqueNames.Add("Kamran"); // ⚠️ Duplicate item! This will be ignored automatically.

                Console.WriteLine("--- HashSet Elements (No Duplicates) ---");
                foreach (string name in uniqueNames)
                {
                    Console.WriteLine(name); // "Kamran" appears exactly once
                }

                Console.ReadLine();
            }
        }
    }
}
 */