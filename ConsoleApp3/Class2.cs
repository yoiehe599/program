using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class2
    {
        static int j = 20;
        public static void Main()
        {
            int j = 30;
            Console.WriteLine(j);
            Console.WriteLine(Class2.j);
        }
    }
}
