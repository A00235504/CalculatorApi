using System;
namespace CalculatorLibrary
{
    public class CalculatorLibraryClass
    {
        public decimal Add(decimal input1, decimal input2)
        {
            return (input1 + input2);
        }

        public decimal Subtract(decimal input1, decimal input2)
        {
            return (input1 - input2);
        }

        public decimal Multiply(decimal input1, decimal input2)
        {
            return (input1 * input2);
        }

        public decimal Divide(decimal input1, decimal input2)
        {
            if (input1 == 0 || input2 == 0)
            {
                return -1;
            }
            else {
                return (input1 / input2);
            }
        }
    }
}
