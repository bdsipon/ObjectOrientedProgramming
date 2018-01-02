using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
   public class Polymorphism
    {
        public virtual void TyreSize()
        {

            Console.WriteLine("Default Tyre size is 13 inches");
        }
    }
    public class Ferrari:Polymorphism
    {
       

        public override void TyreSize()
        {
            
            Console.WriteLine("THe ferrari is system alowedd");
        }
    }
}
