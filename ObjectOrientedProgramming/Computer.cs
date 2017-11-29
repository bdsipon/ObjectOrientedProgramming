using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
 abstract class Computer
    {
        public abstract void turnon(string name);
        
    }
    class Man:Computer
    {
        public override void turnon( string name)
        {
            Console.WriteLine("Hello World");
        }
    }
   

}
