using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration
            int x, y, a, b;

            // Assignment operator
            x = 3;
            y = 4;
            a = 5;
            b = 6;

            // There are many mathematical operators...
            // Addition operator
            x = 3 + 4;

            // Subtraction operator
            x = 4 - 3;

            // Multiplication operator
            x = 10 / 5;

            // Order of operations using parenthesis
            x = (x + y) * (a - b);

            // There are many operators used to evaluate values...
            // Equality operator
            if (x == y) { }

            // Greater than operator
            if (x > y) { }

            // Less than operator
            if (x < y) { }

            // Greater or equal to operator
            if (x >= y) { }

            // Less or equal to operator
            if (x <= y) { }

            /*
             * There are two "conditional" operators as well that can 
             * be used to expand / enchance an evaluation... 
             * ... and can be combined together multiple times.
             */
            // Conditional AND operator ...
            if ((x > y) && (a > b)) { }

            // Conditional OR operator ...
            if ((x > y) || (a > b)) { }

            // Also, here's the in-line conditional operator
            // we learned about in the previos lesson ...
            string message = (x == 1) ? "Car" : "Boat";

            // Member access and method invocation
            Console.WriteLine("Hi");

            // x + y;
        }
    }
}
