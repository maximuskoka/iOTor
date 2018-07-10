using System;

namespace Calculator
{
    public class Logarithm : OoneCalculator 
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
      
        }
    }
}
