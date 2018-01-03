using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
   public class Generics
    {
        public void GenericList()
        {
            List<string> mylist = new List<string>();
            mylist.Add("Sipon");
            mylist.Add("\nPopy");
            mylist.Add("\nZisan");

            foreach (string s in mylist)
           Console.Write(s.ToString() + "");

            mylist.Sort();
            Console.WriteLine("\n after sorting");
            foreach (string s in mylist)
                Console.Write(s.ToString()+"");
            mylist.Remove("Sipon");
            Console.WriteLine("\nRemoving Sipon");
            foreach (string s in mylist)
                Console.Write(s.ToString());

            mylist.Insert(2, "Mathew");
            Console.WriteLine("\n Inserting Mathew at index position 2");
            foreach (string s in mylist)
                Console.WriteLine(s.ToString() + "");

        }
      public void GenericDictionary()
        {
            Dictionary<string, string> movie = new Dictionary<string, string>();
            movie.Add("Sci-fi", "Star Wars");
            movie.Add("Action", "The one");

            Console.WriteLine(movie["Sci-fi"]);
            foreach(KeyValuePair<string,string> items in movie)
            {
                Console.WriteLine(items.ToString());
            }
            if(movie.ContainsKey("Sci-fi"))
            {
                Console.WriteLine("Key found. Value is " + movie["Sci-fi"]);
                 
            }
            else
            {
                Console.WriteLine("Key Not fond");
            }
        }
   
    }

}
