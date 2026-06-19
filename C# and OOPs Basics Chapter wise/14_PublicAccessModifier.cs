/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _14_PublicAccessModifier
    {
        public class PublicParent
        {
            public string publicMessage = "Hello from Public! (Accessible everywhere)";
        }

        public class PublicChild : PublicParent
        {
            public void DisplayMessage()
            {
                // ✅ Allowed: Child class can fully access parent's public fields
                Console.WriteLine(publicMessage);
            }
        }

        class Program
        {
            static void Main()
            {
                PublicChild childObj = new PublicChild();
                childObj.DisplayMessage();

                // ✅ Allowed: External code can access public fields directly
                Console.WriteLine(childObj.publicMessage);

                Console.ReadLine();
            }
        }
    }
}


 */