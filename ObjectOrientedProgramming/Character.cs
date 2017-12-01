using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    class Character
    {
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
