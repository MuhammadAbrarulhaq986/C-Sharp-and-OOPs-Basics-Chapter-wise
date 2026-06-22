using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _20_PrivateProtectedAccessModifier
    {
        public class PrivateProtectedParent
        {
            private protected string privateProtectedMessage = "Hello from Private Protected! (Only children in the SAME project)";
        }

        public class PrivateProtectedChild : PrivateProtectedParent
        {
            public void DisplayMessage()
            {
                // ✅ Allowed: Accessible because Child is in the same project assembly
                Console.WriteLine(privateProtectedMessage);
            }
        }

        class Program
        {
            static void Main()
            {
                PrivateProtectedChild childObj = new PrivateProtectedChild();
                childObj.DisplayMessage();

                // ❌ Error if uncommented: External classes (even in same project) cannot view it
                // Console.WriteLine(childObj.privateProtectedMessage); 

                Console.ReadLine();
            }
        }
    }
}

