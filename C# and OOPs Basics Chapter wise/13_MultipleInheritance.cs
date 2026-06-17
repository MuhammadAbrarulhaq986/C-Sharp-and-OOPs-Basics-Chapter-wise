/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _13_MultipleInheritance
    {
        // First Interface
        interface ICamera
        {
            void TakePhoto();
        }

        // Second Interface
        interface IPhone
        {
            void MakeCall();
        }

        // Child Class implementing both interfaces
        class SmartPhone : ICamera, IPhone
        {
            public void TakePhoto()
            {
                Console.WriteLine("Photo captured successfully!");
            }

            public void MakeCall()
            {
                Console.WriteLine("Dialing number and placing a call...");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Create an object of the class that implements multiple behaviors
                SmartPhone myPhone = new SmartPhone();

                // Accessing methods from both interfaces
                myPhone.MakeCall();
                myPhone.TakePhoto();

                // Keeps the console window open
                Console.ReadLine();
            }
        }
    }
}

 */