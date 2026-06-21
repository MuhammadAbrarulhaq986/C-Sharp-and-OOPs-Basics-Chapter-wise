using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    public class ProtectedInternalParent
    {
        protected internal string protectedInternalMessage = "Hello from Protected Internal! (Same project OR sub-project children)";
    }

    public class ProtectedInternalChild : ProtectedInternalParent
    {
        public void DisplayMessage()
        {
            // ✅ Allowed: Child can access it seamlessly
            Console.WriteLine(protectedInternalMessage);
        }
    }

    class Program
    {
        static void Main()
        {
            ProtectedInternalChild childObj = new ProtectedInternalChild();
            childObj.DisplayMessage();

            // ✅ Allowed: Acts like internal within the same project assembly
            Console.WriteLine(childObj.protectedInternalMessage);

            Console.ReadLine();
        }
    }
}

