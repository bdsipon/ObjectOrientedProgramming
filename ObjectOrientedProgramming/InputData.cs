using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    class InputData
    {
        public void input(string number)
        {
            double number1;
            double.TryParse(number, out number1);
        }
    }
}
