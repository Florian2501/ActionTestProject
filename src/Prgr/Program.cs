using System;

namespace Prgr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("2 * 3 = {0}",Testlib.Class1.multiply(2,3));
            System.Console.WriteLine("2 + 3 = {0}",Testlib.Class1.add(2,3));
        }
    }

    /// <summary>
    ///This should be visible in the docs
    /// </summary>
    class SeeMeInDocs{
        public int a;
    }
}
