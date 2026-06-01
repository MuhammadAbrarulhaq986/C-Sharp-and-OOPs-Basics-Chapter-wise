/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class CopyConstructor_03
    {
        class Student
        {
            public string name;
            public int age;

            public Student(string n, int a)
            {
                name = n;
                age = a;
            }

            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }

            public Student(Student s)
            {
                name = s.name;
                age = s.age;
            }
            public void Display()
            {
                Console.WriteLine($"Name: {name}, Age: {age}");
            }
        }

        class Program
        {
            static void Main(String[] args)
            {
                Student s1 = new Student("Abrar", 23);
                Student s2 = new Student(s1);
                s2.Display();
            }
        }
    }
}
*/