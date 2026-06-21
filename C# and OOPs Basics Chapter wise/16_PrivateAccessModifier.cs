/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _16_PrivateAccessModifier
    {
    
        public class PrivateParent
        {
            private string privateMessage = "Hello from Private! (Hidden completely)";
        }

        public class PrivateChild : PrivateParent
        {
            public void DisplayMessage()
            {
                // ❌ Error if uncommented: Private fields are not visible to child classes
                // Console.WriteLine(privateMessage); 

                Console.WriteLine("Private members cannot be accessed directly by child classes.");
            }
        }

        class Program
        {
            static void Main()
            {
                PrivateChild childObj = new PrivateChild();
                childObj.DisplayMessage();

                Console.ReadLine();
            }
        }
    }
}

 */