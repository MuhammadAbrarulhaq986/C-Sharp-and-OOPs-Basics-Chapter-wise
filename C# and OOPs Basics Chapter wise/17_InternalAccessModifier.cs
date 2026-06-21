/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _17_InternalAccessModifier
    {
        public class InternalParent
        {
            internal string internalMessage = "Hello from Internal! (Accessible within the same project)";
        }

        public class InternalChild : InternalParent
        {
            public void DisplayMessage()
            {
                // ✅ Allowed: Accessible because parent and child sit in the same assembly project
                Console.WriteLine(internalMessage);
            }
        }

        class Program
        {
            static void Main()
            {
                InternalChild childObj = new InternalChild();
                childObj.DisplayMessage();

                // ✅ Allowed: External classes in the SAME project can read internal items
                Console.WriteLine(childObj.internalMessage);

                Console.ReadLine();
            }
        }
    }
}


 */