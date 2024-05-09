using System;
using System.Collections.Generic;
using System.Linq;
namespace Begining_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Intro
            /// LINQ: Language Indpendent Query 
            /// Use 40+ C# Function (Query Operator) Against Data, Regardless of Data Store
            /// L2Object, L2XML, L2ADO, L2SQL(ORM) (C# 3., .Net Framework 3.5)
            /// .NetFramework 3.5 SP1 : EF (ORM) L2EF 
            #endregion

            #region Implict Typed Local Variable
            //var D = 123.456;
            //Console.WriteLine(D.GetType());
            //D = "Hello"; Not Valid, C# is a strongly typed language, statically typed language 
            #endregion

            #region Extension Method
            //int x = 12345;
            //int y = x.Mirror();
            //Console.WriteLine(y);
            #endregion

            #region Immutable Class
            // The value of the object properties can't be changed. Only set in creating objects
            //Employee E1 = new Employee() { ID = 101, Name = "Aly", Salary = 5000 };
            //Console.WriteLine(E1.GetType().Name);
            //Console.WriteLine(E1);
            //Employee E2 = new Employee() { ID = 101, Name = "Aly", Salary = 5000 };
            //if (E1.Equals(E2))
            //    Console.WriteLine("Value EQ");
            #endregion

            #region Anonymous Type
            // Its job to create the class and override the functions as we did in Employee,
            // Which make it immutable class
            // All objects with the sama signature are inistitiated from the same anonymous class
            //var E1 = new { ID = 101, Name = "Aly", Salary = 5000 };
            //var E2 = new { ID = 101, Name = "Aly", Salary = 5000 };
            //var E3 = new { ID = 101, Salary = 5000M, Name = "Aly"};
            //Console.WriteLine(E1.GetType().Name);
            //Console.WriteLine(E1.GetType().FullName);
            //E1.Name = "Samir";// Not Valid, Immutable Object;
            //if (E1.GetType().Name == E2.GetType().Name)
            //    Console.WriteLine("Same Class");
            //if (E1.GetType().Name == E3.GetType().Name)
            //    Console.WriteLine("Same Class");
            //Console.WriteLine(E1.GetHashCode());
            //Console.WriteLine(E2.GetHashCode());
            //Console.WriteLine(E3.GetHashCode());

            //var P1 = new { ProductID = 5, ProductName = "Pens" };
            //Console.WriteLine(P1.GetType().Name);
            #endregion

            /// LINQ Queries Against any Sequence
            /// Sequence : Class Implementing IEnumerable<T> Interface
            /// Local Sequence : L2O . L2ADO , L2XML
            /// Remote Sequence : L2SQL , L2EF
            /// Sequence Contains Elemnents

            List<int> Lst = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<string> NameLst = new List<string> { "Ahmed Aly", "Sayed Samir", "Sally Salah" };

            #region EX01 LINQ

            //IEnumerable<int> Result = Enumerable.Where(Lst, i => i % 2 == 0);

            ///Fluent Syntax
            ///Static Function member in Enumerable Class
            //var Result = Enumerable.Where(Lst, i => i % 2 == 0);//.OrederByDescending(i=>i);


            /// Extension Method
            //var R = Lst.Where(i => i % 2 == 0);


            /// Query Expression \\ Query Syntax (SQL LIKE)
            //var RR = from i in Lst
            //         where i % 2 == 0
            //         //orderby i descending
            //         select i;
            /// SQL Like Style , valid for only Subset of (40+ LINQ Operators)
            /// Some cases it is easier to write Query using Query Expression vs Fluent Syntac (Join , Group , Let , Into)
            /// Starts with From , introduce Range Variable (i) : represent each and every element in Input Sequence
            /// End with select or Group By 
            #endregion

            #region Defferd Execution
            ///Most of LINQ Operators , Deffered Execution 
            ///The Querey isn't executed until there is an enumeration is executing
            ///So Result in memory is pointed to the Lst , so it see the latest version of it before execution

            //var Result = Lst.Where(i => i % 2 == 0);//.OrderBy(i=>i);
            //Console.WriteLine(Result.GetType().Name);

            //Lst.Remove(2);
            //Lst.AddRange(new int[] { 10, 11, 12, 13 });

            //foreach (var item in Result)
            //    Console.Write($"{item} , ");

            //Lst.AddRange(new int[] { 14, 15, 16 });

            //Console.WriteLine("");

            //foreach (var item in Result)
            //    Console.Write($"{item} , ");

            //Console.WriteLine(""); 
            #endregion

            #region Imidiate Execution
            ///Imidiate Execution
            ///Casting (ToList() , ToArray()) , Single Element Operators are Imidiate Execution Operators
            //List<int> MyLst = Lst.Where(i => i % 2 == 0).ToList();
            ///LHS Type is List<T> , RHS Type is IEnumerable
            ///LHS is Derived Class , RHS is Base Class So Casting is needed by ToList()

            //var Result = Lst.Where(i => i % 2 == 0).ToList();//.OrderBy(i=>i);
            //Console.WriteLine(Result.GetType().Name);

            //Lst.Remove(2);
            //Lst.AddRange(new int[] { 10, 11, 12, 13 });

            //foreach (var item in Result)
            //    Console.Write($"{item} , ");

            //Lst.AddRange(new int[] { 14, 15, 16 });

            //Console.WriteLine("");

            //foreach (var item in Result)
            //    Console.Write($"{item} , ");

            //Console.WriteLine("");
            #endregion

        }
    }
}
