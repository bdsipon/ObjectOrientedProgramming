using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Encapsulation
    {
        private static  string name;



        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
     public void print()
        {
            Console.WriteLine("My name is " + name);
        }
    }
}
