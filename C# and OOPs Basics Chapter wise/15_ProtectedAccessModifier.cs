/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _15_ProtectedAccessModifier
    {
        public class ProtectedParent
        {
            protected string protectedMessage = "Hello from Protected! (Only for family/subclasses)";
        }

        public class ProtectedChild : ProtectedParent
        {
            public void DisplayMessage()
            {
                // ✅ Allowed: Child class has absolute access to protected fields
                Console.WriteLine(protectedMessage);
            }
        }

        class Program
        {
            static void Main()
            {
                ProtectedChild childObj = new ProtectedChild();
                childObj.DisplayMessage();

                // ❌ Error if uncommented: External code cannot access protected members
                // Console.WriteLine(childObj.protectedMessage); 

                Console.ReadLine();
            }
        }
    }
}

 */
