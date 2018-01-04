using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Program
    {
        public enum attendance
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }

        struct book{
            public string Firstname;
           public string Secondname;


        }
        static void Main(string[] args)
        {
            attendance present = attendance.Monday;
            Console.WriteLine(present);
            book language, writer;

            language.Firstname = Console.ReadLine();
            writer.Secondname = Console.ReadLine();



            Console.WriteLine("{0}/n{1}", language.Firstname,writer.Secondname);
            
           
            var inter = new derived();
            inter.Test();
            inter.Test1();
            inter.test2();
            inter.test3();
            // Abstraction
            //var mydog = new Dog();
            //mydog.Eat();
            //Animal mypet = mydog;
            //mypet.Eat();
            //mydog.Sound();

            //var Vehicle = new Polymorphism();
            //Vehicle.TyreSize();

            //var gen = new Generics();
            //gen.GenericList();
            //gen.GenericDictionary();
            var cons1 = new Encaps();
            var cons = new Encaps("Sipon",18);
            cons.hidden();


            var en = new Encapsulation();
            en.Name = Console.ReadLine();
            en.print();

            Console.ReadLine();
        }
    }
}
