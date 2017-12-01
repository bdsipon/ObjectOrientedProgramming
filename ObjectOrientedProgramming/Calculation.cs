using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    class Calculation
    {
public void Calculate(string argOperation, double firstNumber,double secondNumber)
        {
            double result;
            switch(argOperation.ToLower())
            {
                case "add":
                    result = firstNumber + secondNumber;
                    break;

                case "substract":
                    result = firstNumber - secondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Specification is not recognised");
            }
        }
    
       

    }
}
