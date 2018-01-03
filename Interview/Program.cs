using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstraction
            //var mydog = new Dog();
            //mydog.Eat();
            //Animal mypet = mydog;
            //mypet.Eat();
            //mydog.Sound();

            //var Vehicle = new Polymorphism();
            //Vehicle.TyreSize();

            var gen = new Generics();
            gen.GenericList();
            gen.GenericDictionary();

            Console.ReadLine();
        }
    }
}
