/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _25_UsingTheBaseKeywordInOverriding
    {
        // Base Class representing a web identity
        public class Web
        {
            public string name = "DotNetTricks";

            // Virtual member method to allow overriding
            public virtual void ShowData()
            {
                Console.WriteLine("Website Name: " + name);
            }
        }

        // Derived class inheriting from Web
        public class Stream : Web
        {
            public string s = "Computer Science";

            // Overriding the base class method
            public override void ShowData()
            {
                // ✅ Calling the base class's version of ShowData() first
                base.ShowData();

                // Appending additional subclass logic
                Console.WriteLine("About: " + s);
            }
        }

        class Program
        {
            static void Main()
            {
                // Creating object of the derived class
                Stream E = new Stream();

                // Invokes the overridden method which chains back to the base
                E.ShowData();

                Console.ReadLine();
            }
        }
    }
}

 */