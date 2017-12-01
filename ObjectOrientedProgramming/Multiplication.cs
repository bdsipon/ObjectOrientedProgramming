using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    class Multiplication
    {
        public void mul()
        {
            string username, password;
            int ctr = 0,dd = 0;
            do
            {
                username = Console.ReadLine();
                password = Console.ReadLine();
                if (username == "username" && password == "password")
                {
                    ctr = 3;
                    dd = 1;
                }
                else
                {
                    ctr++;
                    dd = 0;

                }
            }
            while ((username != "username" || password != "password") && (ctr!=3));
                    {
                if(dd==0)
                {
                    Console.WriteLine("Login Attempt more than three tiem. Try later");
                }
                else if(dd==1)
                {
                    Console.WriteLine("Successful");
                }

                }
            }
         
            



       
    }
}
