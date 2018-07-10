using System;

namespace Calculator
{
    public class Module : OoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);

        }
    }
}
