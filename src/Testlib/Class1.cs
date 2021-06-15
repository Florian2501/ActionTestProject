using System;

namespace Testlib
{
    /// <summary>
    ///This is the only class of my Testlib. It devides a method to multply and to add integers.
    /// </summary>
    public class Class1
    {
        /// <summary>
        ///This Method multplies two integer values.
        /// </summary>
        /// <returns>
        /// The product of the two input integers.
        /// </returns>
        public static int multiply(int a, int b) => a*b;

        /// <summary>
        ///This Method adds two integer values.
        /// </summary>
        /// <returns>
        /// The sum of the two input integers.
        /// </returns>
        public static int add (int a, int b)=>a+b;
    }
}
