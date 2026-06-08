using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _11_HierarchicalInheritance
    {
        // Parent Class (Base Class)
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("This animal is eating food.");
            }
        }

        // Child Class 1 (Derived from Animal)
        class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("The dog is barking: Woof! Woof!");
            }
        }

        // Child Class 2 (Derived from Animal)
        class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine("The cat is meowing: Meow! Meow!");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("--- Testing Dog Object ---");
                Dog myDog = new Dog();
                myDog.Eat();  // Inherited method
                myDog.Bark(); // Child class method

                Console.WriteLine("\n--- Testing Cat Object ---");
                Cat myCat = new Cat();
                myCat.Eat();  // Inherited method
                myCat.Meow(); // Child class method

                // Keeps the console window open
                Console.ReadLine();
            }
        }
    }
}

