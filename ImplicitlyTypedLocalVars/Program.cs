using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            DeclareImplicitVars();

            Console.ReadLine();
        }

        static void DeclareExplicitVars()
        {
            int myInt = 0;
            bool myBool = true;
            string myString = "Time, marches on...";
        }
        static void DeclareImplicitVars()
        {
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            Console.WriteLine($"myInt is a {myInt.GetType().Name}");
            Console.WriteLine($"myBool is a {myBool.GetType().Name}");
            Console.WriteLine($"myString is a {myString.GetType().Name}");
        }
    }
}
