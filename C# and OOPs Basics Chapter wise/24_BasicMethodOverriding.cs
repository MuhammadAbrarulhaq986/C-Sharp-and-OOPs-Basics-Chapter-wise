/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _24_BasicMethodOverriding
    {
        // Base Class representing a generic animal
        public class Animal
        {
            // Declaring a virtual method that can be overridden by child classes
            public virtual void MakeSound()
            {
                Console.WriteLine("The animal makes a generic sound.");
            }
        }

        // Derived class inheriting from Animal
        public class Dog : Animal
        {
            // Intentionally overriding the base class implementation
            public override void MakeSound()
            {
                Console.WriteLine("The dog barks.");
            }
        }

        // Another derived class inheriting from Animal
        public class Cat : Animal
        {
            // Intentionally overriding the base class implementation
            public override void MakeSound()
            {
                Console.WriteLine("The cat meows.");
            }
        }

        class Program
        {
            static void Main()
            {
                // Creating instances using polymorphism 
                Animal myAnimal = new Animal();
                Animal myDog = new Dog();
                Animal myCat = new Cat();

                // Calling the methods (resolves dynamically at run-time)
                myAnimal.MakeSound(); // Outputs generic sound
                myDog.MakeSound();    // Outputs dog barks
                myCat.MakeSound();    // Outputs cat meows

                Console.ReadLine();
            }
        }
    }
} */
