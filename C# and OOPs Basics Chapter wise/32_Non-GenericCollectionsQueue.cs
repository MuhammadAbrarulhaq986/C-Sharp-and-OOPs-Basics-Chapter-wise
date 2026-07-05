using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _32_Non_GenericCollectionsQueue
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Creating a Queue
                Queue queue = new Queue();

                // Enqueue adds an element to the end of the queue
                queue.Enqueue("Customer 1");
                queue.Enqueue("Customer 2");
                queue.Enqueue(3);

                Console.WriteLine("--- Queue Elements ---");
                foreach (object item in queue)
                {
                    Console.WriteLine(item);
                }

                // Dequeue removes and returns the element at the beginning of the queue
                Console.WriteLine($"\nProcessing (Dequeue): {queue.Dequeue()}");
                Console.WriteLine($"Next in line (Peek): {queue.Peek()}");

                Console.ReadLine();
            }
        }
    }
}