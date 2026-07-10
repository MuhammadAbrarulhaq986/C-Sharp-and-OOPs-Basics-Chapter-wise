/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _36_CustomGenericImplementationsCreatingAGenericClass
    {
        // Generic Box Class using placeholder token <T>
        public class Box<T>
        {
            private T content;

            public void SetContent(T item)
            {
                content = item;
            }

            public T GetContent()
            {
                return content;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // 1. Initializing Box specifically for storing integers
                Box<int> intBox = new Box<int>();
                intBox.SetContent(12345);
                Console.WriteLine($"Integer Box Content: {intBox.GetContent()}");

                // 2. Initializing the exact same class for string types instead
                Box<string> stringBox = new Box<string>();
                stringBox.SetContent("Learning Generics is fun!");
                Console.WriteLine($"String Box Content: {stringBox.GetContent()}");

                Console.ReadLine();
            }
        }
    }
}
 */