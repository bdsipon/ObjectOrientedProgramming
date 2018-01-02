using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class GET_SET
    {
        private static string name;
        public void print()
        {
            Console.WriteLine("\nMy name is " + name);
        }

        private string Name
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
    }
}
