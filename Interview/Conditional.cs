using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
   public class Conditional
    {
        public int result, num1, num2,opt;
      
        public void ifelse()
        {

            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());

            int opt = Int32.Parse(Console.ReadLine());

            if (opt==1)
            {
                result = num1 + num2;
                Console.WriteLine(result);
            }
            else if(opt==2)
            {
                result = num1 - num2;
                Console.WriteLine(result);
            }
            else if(opt==3)
            {
                result = num1 / num2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }

        public void switches()
        {

            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());

            int opt = Int32.Parse(Console.ReadLine());

            switch(opt)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine(result);
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine(result);
                    break;

                case 3:
                    result = num1 / num2;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
                   
                 
            }

        }

        public void calculation()
        {
            double result;
            const double lessthantenthousand = 0.05;
            const double tenthousandtoonelac = .08;
            const double morethantenthousand = .1;

            double money = Double.Parse(Console.ReadLine());

            if (money < 10000)
            {
                result = money * lessthantenthousand;
                Console.WriteLine(result);
            }
            else if (money>=10001 && money <= 100000)
            {
                result = money * tenthousandtoonelac;
                Console.WriteLine(result);
            }
            else if (money > 100000)
            {
                result = money * morethantenthousand;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Wrong Entry");
            }
        }
    }
}
