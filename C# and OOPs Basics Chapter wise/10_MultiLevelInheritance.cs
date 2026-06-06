using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _10_MultiLevelInheritance
    {


// Level 1: The Base Class
public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    // Level 2: Derived from Animal
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    // Level 3: Derived from Dog
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weeping...");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an object of the lowest child class
            Puppy myPuppy = new Puppy();

            // It has access to methods from ALL levels of the hierarchy
            myPuppy.Eat();  // Inherited from Animal (Grandparent)
            myPuppy.Bark(); // Inherited from Dog (Parent)
            myPuppy.Weep(); // From Puppy itself (Child)
        }
    }
}
}
