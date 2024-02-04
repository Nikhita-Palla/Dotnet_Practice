/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator_Assembly
{
    public class Class1
    {
        
        public int add(int a,int b) 
        {
            return(a + b);
        }
        public int subtract(int a, int b)
        {

            return (a - b);
        }
        public int multiply(int a, int b)
        {
            return (a * b);
        }
        public int divide(int a,int b)
        {
            return (a / b);
        }
        public int remainder(int a,int b)
        {
            return (a % b);
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Assembly
{
    /// <summary>
    /// Provides basic arithmetic operations.
    /// </summary>
    public class Class1
    {
        /// <summary>
        /// Adds two integers.
        /// </summary>
        /// <param name="a">The first integer.</param>
        /// <param name="b">The second integer.</param>
        /// <returns>The sum of the two integers.</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts one integer from another.
        /// </summary>
        /// <param name="a">The integer to subtract from.</param>
        /// <param name="b">The integer to subtract.</param>
        /// <returns>The result of subtracting <paramref name="b"/> from <paramref name="a"/>.</returns>
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies two integers.
        /// </summary>
        /// <param name="a">The first integer.</param>
        /// <param name="b">The second integer.</param>
        /// <returns>The product of the two integers.</returns>
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides one integer by another.
        /// </summary>
        /// <param name="a">The dividend.</param>
        /// <param name="b">The divisor.</param>
        /// <returns>The result of dividing <paramref name="a"/> by <paramref name="b"/>.</returns>
        public int Divide(int a, int b)
        {
            return a / b;
        }

        /// <summary>
        /// Computes the remainder of dividing one integer by another.
        /// </summary>
        /// <param name="a">The dividend.</param>
        /// <param name="b">The divisor.</param>
        /// <returns>The remainder of dividing <paramref name="a"/> by <paramref name="b"/>.</returns>
        public int Remainder(int a, int b)
        {
            return a % b;
        }
    }
}
