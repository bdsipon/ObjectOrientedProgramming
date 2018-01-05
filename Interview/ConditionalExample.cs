using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class ConditionalExample
    {
        public void calculation()
        {
            double result;
            const double lessthantenthousand = 0.05;
            const double tenthousandtoonelac = .08;
            
            double money = Int32.Parse(Console.ReadLine());

            if(money>10000)
            {
                result = money * lessthantenthousand;
                Console.WriteLine(result);
            }
            else if(money>10000 && money<10000)
            {
                result = money * tenthousandtoonelac;
                Console.WriteLine(result);
            }
        }
    }
}
