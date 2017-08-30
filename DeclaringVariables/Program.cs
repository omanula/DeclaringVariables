using System;

namespace DeclaringVariables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Don't forget the semi-colon at the end of a line!!! //

            int x;
            int y;
            /* Declaration of variables. Allocate space in the memory  large
             * enough to store numeric values. Variables able to hold values. 
             * Values (integers) can be applied to the variables now. 
             * int = integer in C#, no fractions/decimals (2,147,000 max)
             */

            x = 7;
            // Assign value to variable //
            y = x + 3;
            Console.WriteLine(y);
            // Capital W in Write and capital L in Line needed//

            Console.ReadLine();
            // Capital R in Read and capital L in Line needed//

        }
    }
}
