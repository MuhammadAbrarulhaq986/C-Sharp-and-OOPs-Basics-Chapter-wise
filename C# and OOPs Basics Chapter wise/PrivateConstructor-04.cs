/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class PrivateConstructor
    {
        class Singleton
        {
            private static Singleton instance;

            private Singleton() 
            {
                Console.WriteLine("Singleton instance created.");
            }
            public static Singleton GetInstance() 
            {
                if ( instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Singleton s1 = Singleton.GetInstance(); 
            }
        }
    }
}
 */