using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Attempt to connect to MySQL DB
            var db = new DBConnect();

            // Write to db
            db.Insert("INSERT INTO People (name, age) VALUES ('Sean', 30);");

            // Read from db
            var data = db.Select("SELECT * FROM LinqExploration.People;");

            // Display list
            foreach (object rec in data)
            {
               Console.WriteLine(rec);
            }
        }
    }
}
