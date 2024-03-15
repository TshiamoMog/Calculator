using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// A type of operation the calculator can perform
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Adds two values togetheer
        /// </summary>
        Addition,

        /// <summary>
        /// Subtracts one value from another value
        /// </summary>
        Minus,

        /// <summary>
        /// Divides one value by another value
        /// </summary>
        Division,

        /// <summary>
        /// Multiplies two values together
        /// </summary>
        Multiplication,
    }
}
