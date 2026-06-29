using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _26_SealedClass_PreventingInheritance_
    {
        // Marked as sealed to strictly avoid further inheritance
        public sealed class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Eating...");
            }
        }

        // ❌ COMPILATION ERROR: 'Dog': cannot derive from sealed type 'Animal'
        // class Dog : Animal 
        // {
        // }

        class Program
        {
            static void Main(string[] args)
            {
                // Note: Even though a sealed class cannot be inherited,
                // we can still create objects and use its public members safely!
                Animal myAnimal = new Animal();
                myAnimal.Eat();

                Console.ReadLine();
            }
        }
    }
}

