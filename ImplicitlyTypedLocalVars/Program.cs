using System;

namespace ImplicitlyTypedLocalVars
{
    class Program
    {
        static void Main()
        {
            DeclareExplicitVars();
            DeclareImplicitVars();

            Console.ReadLine();
        }

        static void DeclareExplicitVars()
        {
            int myInt = 0;
            bool myBool = true;
            string myString = "Time, marches on...";

            Console.WriteLine("Declaring Explicit variables: ");

            Console.WriteLine($"myInt is a {myInt.GetType().Name}");
            Console.WriteLine($"myBool is a {myBool.GetType().Name}");
            Console.WriteLine($"myString is a {myString.GetType().Name}");
            Console.WriteLine();
        }
        static void DeclareImplicitVars()
        {
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            Console.WriteLine("Declaring implicit variables: ");

            Console.WriteLine($"myInt is a {myInt.GetType().Name}");
            Console.WriteLine($"myBool is a {myBool.GetType().Name}");
            Console.WriteLine($"myString is a {myString.GetType().Name}");
            Console.WriteLine();
        }
    }
}
