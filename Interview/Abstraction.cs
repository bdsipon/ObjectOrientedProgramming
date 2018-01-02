using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public abstract class Abstraction
    {
        public abstract void Eat();
        public void Sound()
        {
            Console.WriteLine("Dog can sound");
        }
    }

    class Dog:Abstraction
    {
        public override void Eat()
        {
            Console.WriteLine("Dog can eat");
        }
    }
}
