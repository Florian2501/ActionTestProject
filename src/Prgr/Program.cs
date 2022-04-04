using System;

namespace Prgr
{
    public class Program
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
    public class SeeMeInDocs{
        public int a;
    }
    /// <summary>
    ///This should also be visible in the docs. Greetings from Flo
    /// </summary>
    public class SeeMeInDocs2{
        public int b;
        public SeeMeInDocs c;
    }
}
