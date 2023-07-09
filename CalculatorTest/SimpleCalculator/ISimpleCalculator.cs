// Author: Chris Knowles
// Date: Jul 2023
// File: ISimpleCalculator.cs
// Version: 1.0.0
// Notes: Interface for the SimpleCalculator implementation utilised in the solution
//        for the GL Education tech test

namespace SimpleCalculator
{
    /// <summary>
    /// Interface <c>ISimpleCalculator</c> defining various arithmetic operations intended
    /// to be implemented by concrete "calculator-related" classes
    /// </summary>
    public interface ISimpleCalculator
    {
        public int Add(int start, int amount);
        public int Subtract(int start, int amount);
    }
}
