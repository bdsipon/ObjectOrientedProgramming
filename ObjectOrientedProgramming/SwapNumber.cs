using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    class SwapNumber
    {
        public void swap()
        {

            int number1, number2, temp;
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.Read();
        }
  
    }
}
