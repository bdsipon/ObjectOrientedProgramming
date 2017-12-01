using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    class Average
    {
        public  void av()
        { 
        int a, b, c,  result;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
           c = int.Parse(Console.ReadLine());
            
            result = (a + b   )* c;
           int result1 = a * b + b * c;
            Console.Write("The result is{0}",result);
            Console.WriteLine(result1);
        }
    }
}
