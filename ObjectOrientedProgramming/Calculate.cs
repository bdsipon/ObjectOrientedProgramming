using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    class Calculate
    {
        public static int Square(int number)
        {
            Console.WriteLine("Integer Square Calculated");
            return number * number;
        }
        public static double Square(double number)
        {
            Console.WriteLine("Double Square Calculated");
            return number * number;
        }
    }
}
