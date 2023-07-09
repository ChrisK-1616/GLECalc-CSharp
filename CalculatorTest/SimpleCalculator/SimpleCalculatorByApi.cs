// Author: Chris Knowles
// Date: Jul 2023
// File: SimpleCalculatorByApi.cs
// Version: 1.0.0
// Notes: Implementation of the interface ISimpleCalculator (from GL Education tech test) expected
//        to be used in an ASPNET Core Web RESTful API 

namespace SimpleCalculator
{
    /// <summary>
    /// Concrete implementation of the interface <c>ISimpleCalculator</c> intended to be utilised by
    /// an ASPNET Core Web RESTful API
    /// </summary>
    public class SimpleCalculatorByApi : ISimpleCalculator
    {
        /// <summary>
        /// Method that uses the add operator to provide the addition of <c>start</c> and <c>amount</c>
        /// values passed in as arguments to the method
        /// </summary>
        /// <param name="start"> Value to be added to the <c>amount</c> value </param>
        /// <param name="amount"> Value to be added to the <c>start</c> value </param>
        /// <returns> Addition of the <c>start</c> and <c>amount</c> values </returns>
        /// <exception></exception>
        /// <example> start = 10, amount = 5 will return value 10 + 5 = 15 </example>
        /// <code></code>
        /// <remarks></remarks>
        public int Add(int start, int amount)
        {
            return start + amount;
        }

        /// <summary>
        /// Method that uses the subtract operator to provide the subtraction of <c>amount</c> value from
        /// <c>start</c> value passed in as arguments to the method
        /// </summary>
        /// <param name="start"> Value to be subtracted from by the <c>amount</c> value </param>
        /// <param name="amount"> Value to be subtracted from the <c>start</c> value </param>
        /// <returns> Subtraction of the <c>amount</c> value from the <c>start</c> value </returns>
        /// <exception></exception>
        /// <example> start = 10, amount = 5 will return value 10 - 5 = 5 </example>
        /// <code></code>
        /// <remarks></remarks>
        public int Subtract(int start, int amount)
        {
            return start - amount;
        }
    }
}