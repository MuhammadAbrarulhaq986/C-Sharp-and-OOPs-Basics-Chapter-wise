using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _12_HybridInheritance
    {
        // 1. Base Class
        class Vehicle
        {
            public void Move()
            {
                Console.WriteLine("This vehicle is moving forward.");
            }
        }

        // 2. Interface to enable hybrid capability without breaking C# rules
        interface IElectric
        {
            void ChargeBattery();
        }

        // 3. Derived Class implementing Hybrid Inheritance
        // It inherits from one class (Vehicle) and implements one interface (IElectric)
        class ElectricCar : Vehicle, IElectric
        {
            public void ChargeBattery()
            {
                Console.WriteLine("The battery is charging... 100%!");
            }

            public void DriveSilent()
            {
                Console.WriteLine("Driving smoothly and silently.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Create an object of the hybrid class
                ElectricCar myTesla = new ElectricCar();

                // 1. Calling method from the Parent Class
                myTesla.Move();

                // 2. Calling method from the Interface
                myTesla.ChargeBattery();

                // 3. Calling method from its own Class
                myTesla.DriveSilent();

                // Keeps the console window open
                Console.ReadLine();
            }
        }
    }
}
