using System;

namespace Calculator
{
    public class Sinus : OoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);

        }
    }
}
