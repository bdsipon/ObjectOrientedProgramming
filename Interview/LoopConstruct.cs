using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class LoopConstruct
    {
        public void whiles()
        {
            //int i = 0;
            //int result, num1;

            //num1 = Convert.ToInt32(Console.ReadLine());
            //while (i<=10)
            //{
            //    result = num1 * i;
            //    Console.WriteLine(result);
            //    i++;
            //}

            int num, sum = 0, res = 0;

            while(true)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if(num==-1)
                {
                    break;
                }
                sum = res;
                res = num +res;
                Console.WriteLine(res);
            }

            Console.WriteLine("Pres Enter");
            Console.ReadLine();
        }
        public void do_while()
        {
            int tab, i, res;
            tab = 12;
            i = 1;
            do
            {
                res = tab * i;
                Console.WriteLine(res);
                i++;
            }
            while (i <= 10);
            Console.ReadLine();
        }

        public void for_loop()
        {
            for(int i=1;i<=5; i++)
            {
                for(int j=1; j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }

        public void for_each()
        {
            string[] arr = new string[5];
            arr[0] = "Sipon";
            arr[1] = "Mohammad";
            arr[2] = "Rafiq";
            arr[3] = "Naser";
            arr[4] = "Khaled";
            foreach(string n in arr)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
