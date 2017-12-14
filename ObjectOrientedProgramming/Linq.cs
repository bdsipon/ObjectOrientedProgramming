using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedProgramming
{
    class Linq
    {
       public void lina()
        {

      // the three parts of a Linq Query
      //1. Data Source.
        int[] numbers = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        
        //2. Query Creation
        //numquery is an IEnumberable<int>
        var numQuery = from num in numbers
                       where (num % 2) == 0
                       select num;
            //Query Execution
        foreach(int num in numQuery)
            {
                Console.WriteLine(num);

            }
        }
    }
}
