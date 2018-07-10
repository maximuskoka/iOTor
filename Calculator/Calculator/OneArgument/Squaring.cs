using System;

namespace Calculator
{
    public class Squaring : OoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);

        }
    }
}
