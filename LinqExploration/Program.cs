using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {
                "Burke",
                "Connor",
                "Frank",
                "Everett",
                "Albert",
                "George",
                "Harris",
                "David"
            };

            // The local variable query is initialized with a query expression.
            IEnumerable<string> query = from s in names
                                  where s.Length == 5 
                                  orderby s
                                  select s.ToUpper();

            /*
                This form of query is called a method-based query. 
                The arguments to the Where, OrderBy, and Select operators are called lambda expressions,
                which are fragments of code much like delegates. They allow the standard query operators 
                to be defined individually as methods and strung together using dot notation. 
                Together, these methods form the basis for an extensible query language.
             */
            IEnumerable<string> query2 = names.Where(s => s.Length == 5)
                                             .OrderBy(s => s)
                                             .Select(s => s.ToUpper());

            foreach (string item in query2)
                Console.WriteLine(item);

            // Lamba Expressions and Expression Trees
            Func<string, bool> filter = s => s.Length != 5;
            Func<string, string> extract = s => s;
            Func<string, string> project = s => s.ToLower();

            IEnumerable<string> query3 = names.Where(filter)
                                             .OrderBy(extract)
                                             .Select(project);

            foreach (string item in query3)
                Console.WriteLine(item);
        }
    }
}
