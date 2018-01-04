using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public abstract class Onebyall
    {
        public abstract void Test();
        public virtual void Test1()
        {

        }
       
    }

    public class derived:Onebyall,ITest,ITest1
    {
        public override void Test()
        {
            Console.WriteLine("Hello World");
        }
        public override void Test1()
        {
            Console.WriteLine("Hello World and it is the test");
        }

        public void test2()
        {
            Console.WriteLine("Hello World 2");
        }

        public void test3()
        {
            Console.WriteLine("Hello World 3");
        }
    }

    public class derived1:Onebyall
    {
        public override void Test()
        {
            Console.WriteLine("Hello World");

        }
    }

    public interface ITest
    {
        void test2();
    }

    public interface ITest1
    {
        void test3();
    }
   
    public sealed class Encaps
    {
       private string Location;
        private int Age;

        public Encaps()
        {
            Location = "Dhaka";
            Age = 52;
            Console.WriteLine("{0}\n{1}", Location, Age);
        }

        public Encaps( string location, int age )
        {
            Location = location;
            Age = age;
        }
        public void hidden()
        {
            Console.WriteLine("{0}\n{1}",Location, Age);
        }
             
    }
}
