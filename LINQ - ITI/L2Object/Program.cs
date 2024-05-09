using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static L2Object.ListGenerators;

namespace L2Object
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Deffered Executions
            #region Looping on CustomerList

            //Console.WriteLine(ListGenerators.CustomerList.GetType().Name);

            //foreach (var item in ListGenerators.CustomerList)
            //{
            //    Console.Write(ListGenerators.CustomerList.IndexOf(item) + 1);
            //    Console.WriteLine($"- {item.CustomerID}:{item.CompanyName}");
            //    foreach (var orderitems in item.Orders)
            //    {
            //        Console.WriteLine($"{orderitems.OrderID}:{orderitems.OrderDate}:{orderitems.Total}");
            //    }
            //    Console.WriteLine("---------------------------------------");
            //} 
            #endregion
            //Console.WriteLine(ProductList[0]);
            #region Where - Filteration
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            //Result = from P in ProductList
            //         where P.UnitsInStock == 0
            //         select P;

            //var Result = ProductList.Where(P => (P.UnitsInStock == 0) && (P.Category == "Sports"));
            //Result = from P in ProductList
            //         where (P.UnitsInStock == 0 ) && (P.Category == "Sports")
            //         select P;

            /// Indexed Where Valid only in Fluent Syntax
            /// Can't be written using Query Expression
            /// Get Products that there UnitsInStck =0 and existed in the first 20 elements in the sequence (ProductList)
            //var Result = ProductList.Where((P,i) => P.UnitsInStock ==0 && i <=20);

            #endregion
            #region Select - Transformation Operator
            ///Select outputs columns but where outputs rows
            ///Select the specified data from the List and stored it in a new IEnumerable output sequence of the type of the data.
            ///Project\Transform every Element in Input Sequence to A new Element in Output Seq of New Datatype (or same type) (Existed or Anonymous).
            //var Result = ProductList.Select(P => P.ProductName);
            ///Product => IEnumerable<string(the type of ProductName)>
            //Result = from P in ProductList
            //        select P.ProductName; // The Result is an IEnumerable<string> 

            ///IF i need to select more than one type of data, i should use anonymous datatype of the needed data
            //var Result = ProductList.Where(P => P.UnitsInStock == 0)
            //    .Select(P => new { Id = P.ProductID, P.ProductName });//If i don't specify the new name of the properties
            //i wanna to make it in the anonymous class,
            //                                                          //it will take the name of the base list.
            //Result = from P in ProductList
            //         select new { Id = P.ProductID, P.ProductName };
            ///Product => Anonymous Type
            ///If i need to generate a new List contains the same data but discount the unit price
            //var DiscountedLst = ProductList.Select(P => new Product()
            //{
            //    ProductID = P.ProductID,
            //    Category = P.Category,
            //    ProductName = P.ProductName,
            //    UnitsInStock = P.UnitsInStock,
            //    UnitPrice = 0.9M * P.UnitPrice
            //});
            ///Product => Product
            //DiscountedLst = from P in ProductList
            //                select new Product()
            //                {
            //                    ProductID = P.ProductID,
            //                    Category = P.Category,
            //                    ProductName = P.ProductName,
            //                    UnitsInStock = P.UnitsInStock,
            //                    UnitPrice = 0.9M * P.UnitPrice
            //                };
            ///All of the above is InputSequence 0f Index (N) => Output Sequence of the same Index (N)
            ///Indexed Select, Valid only in Fluent Syntax Format
            //var Result = ProductList.Where(P => P.UnitsInStock == 0)///O/P of Where Seq of 5 Elements.
            //    .Select((P, i) => new { Index = i, Name = P.ProductName });

            //var Result = ProductList.Select(P => new { Name = P.ProductName, NewPrice = P.UnitPrice * 1.1M })//Outputs the columns (ProductName, UnitPrice*1.1)
            //                            .Where(P => P.NewPrice <= 20);//From select output, it outputs the rows that their NewPrice > 20

            //var R01 = ProductList.Select(P => new { Name = P.ProductName, NewPrice = P.UnitPrice * 1.1M });
            //var R02 = R01.Where(P => P.NewPrice > 20);

            //var RR01 = from P in ProductList
            //           select new { Name = P.ProductName, NewPrice = P.UnitPrice * 1.1M };


            //var RR02 = from P in RR01
            //           where P.NewPrice > 20
            //           select P;

            //var RR = from P in ProductList
            //         select new { Name = P.ProductName, NewPrice = P.UnitPrice * 1.1M }
            //         into TaxPrd ///Introduct to new Range Variable to continue Query Using New(Only) Range Variable
            //         where TaxPrd.NewPrice > 20
            //         select TaxPrd;
            #endregion
            #region Ordering Elements
            //var Result = ProductList.OrderBy(P => P.UnitsInStock)
            //    .Select(p => new { p.ProductName, p.UnitsInStock, p.UnitPrice });

            //Result = from P in ProductList
            //         orderby P.UnitsInStock
            //         select new { P.ProductName, P.UnitsInStock, P.UnitPrice };

            //Result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //     .Select(p => new { p.ProductName, p.UnitsInStock, p.UnitPrice });

            //Result = from P in ProductList
            //         orderby P.UnitsInStock descending
            //         select new { P.ProductName, P.UnitsInStock, P.UnitPrice };

            //Result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //    .ThenBy(P=>P.UnitPrice)
            //     .Select(p => new { p.ProductName, p.UnitsInStock, p.UnitPrice });

            //Result = from P in ProductList
            //         orderby P.UnitsInStock descending , P.UnitPrice
            //         select new { P.ProductName, P.UnitsInStock, P.UnitPrice };

            //Result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //    .ThenByDescending(P=>P.UnitPrice)
            //     .Select(p => new { p.ProductName, p.UnitsInStock, p.UnitPrice });

            //Result = from P in ProductList
            //         orderby P.UnitsInStock descending , P.UnitPrice descending
            //         select new { P.ProductName, P.UnitsInStock, P.UnitPrice };


            #endregion
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion
            #region Immediate Execution
            #region Element Operation
            ///Valid only in Fluenlt Syntax, cab be hybrid
            //List<Product> DiscountedLst = new List<Product>();//Empty Sequence

            //var Result = ProductList.First();
            //Result = ProductList.Last();
            //Result = ProductList.First(P => P.UnitsInStock == 0);
            //Result = ProductList.Last(P => P.UnitsInStock == 0);


            ////Result = DiscountedLst.Last(); 
            ////Result = DiscountedLst.First();
            /////if Input Sequence has no elements , it will throw exception  


            //Result = DiscountedLst.FirstOrDefault();
            //Result = DiscountedLst.LastOrDefault();
            /////Return First Element in input sequence , return Default value if Empty Seq
            /////No Exception will be thrown
            /////Result = default(Product)

            ////Result = ProductList.First(P => P.UnitPrice > 300);
            /////Throw Exceptionif no element is matched

            //Result = ProductList.FirstOrDefault(P => P.UnitPrice > 300);
            //Result = ProductList.LastOrDefault(P => P.UnitPrice > 300);

            /////Return Matched Element in input sequence , return Default value if Empty Seq. 
            /////No Exception will be throw

            ///// Element Operation can't be written in Query Syntax. It must be hybrid withh Deffered Execution Queries.
            //var R = (from P in ProductList
            //         where P.UnitsInStock == 0
            //         select new { P.ProductName, P.Category }).First();

            //Result = ProductList.ElementAt(17);
            ////Result = ProductList.ElementAt(170); // Exception
            //Result = ProductList.ElementAtOrDefault(17);

            //DiscountedLst.Add(ProductList[0]);


            //Result = ProductList.Single();
            /////return single element in Sequence (Only one element in input sequence)
            /////Throw Exception if empty sequence or more than one element exists)
            //DiscountedLst.Clear();
            //Result = DiscountedLst.SingleOrDefault();//return null, no exception will be thrown
            ///// Throw Exception if More than one element is existed
            ///// return deafault if no elements are existed 


            //Result = ProductList.Single(P => P.ProductID == 7);
            /////Throw Exception if MOre than one Product Matched or if no elements matches predicates
            //Result = ProductList.SingleOrDefault(P => P.ProductID == 7);
            /// Throw Exception if More than one product matched predicate
            /// return deafault if no elements matchs predicate
            //Console.WriteLine(Result?.ProductName ?? "NA");
            #endregion
            #region Aggregate
            //var Result = ProductList.Count();
            //Result = ProductList.Count(P => P.UnitsInStock == 0);

            //var Result = ProductList.Max();
            //return the product that have tha max value
            //(Based on IComparable<T> and CompareTo() Impelementation in ListGenerators calss) Product

            //var Result = ProductList.Max(P => P.UnitPrice);
            /// Return the max value of UnitPrice not the product that have the max value

            //Product Prd = ProductList.Min();
            ///return the product that have tha min value

            //Result = ProductList.Min(P => P.ProductName.Length);
            /// Return the min value of Length of ProductName not the product that have the max value


            var Rslt = (from P in ProductList
                        where P.ProductName.Length == ProductList.Min(P => P.ProductName.Length)
                        select P).FirstOrDefault();
            ///To outputs the Product Name that have the max or min value of specific parameter

            //var Result = ProductList.Average(P => P.UnitsInStock);
            //var Result = ProductList.Sum(P => P.UnitsInStock);

            //var Result = ProductList.Aggregate(); // Search for it

            //Console.WriteLine(Rslt?.ProductName ?? "NA");
            //Console.WriteLine(Result);
            #endregion
            #region Casting Operators
            //List<Product> UnAvPrds = ProductList.Where(P => P.UnitsInStock == 0).ToList();

            //Product[] Parr = ProductList.Where(P => P.UnitsInStock == 0)
            //    .OrderBy(P => P.UnitsInStock)
            //    .ToArray();
            //var R01 = Parr.Select(P => new { P.ProductName, P.UnitPrice });

            //var Result = ProductList.Where(P => P.UnitsInStock == 0)
            //.ToHashSet();
            //.ToDictionary(P => P.ProductID);//(P=>P.ProductID) is Key Selector  Dic<long,Product)
            //.ToDictionary(P => P.ProductID, Prd => 
            //new { Prd.ProductID, Prd.ProductName });//(KeySelector , ValueSelector) Dic<long,Anonymous[long,string]>
            //.ToLookup(P => P.ProductID);
            //foreach (var item in Result[2])
            //    Console.WriteLine(item);
            #endregion
            #endregion
            #region Generators Operators
            ///Generating Output Sequence
            ///Inly way to call them is as static members from Enumerable Class
            //var Rsult = Enumerable.Range(1, 10);
            //var R01 = Enumerable.Empty<Product>();
            //var R02 = Enumerable.Repeat(3, 10);
            //ProductList[2].ProductName = "Temp";
            //var Result = Enumerable.Repeat(ProductList[2], 5);
            #endregion
            #region Select Many
            List<String> NameList = new List<String>()
            {"Ahmed Aly", "Sally Samir","Taha Tamer" };
            ///Output Seq Count > Input Seq Count
            ///Transform each elemnt in input sequence to sub seq (IEnumeable<>)
            //var Result = NameList.SelectMany(FN => FN.Split(' '))
            //    .OrderBy(SN => SN.Length);

            //var Rsult = from FN in NameList
            //            from SN in FN.Split(' ')
            //            orderby SN.Length
            //            select SN;

            //var R02 = Result.SelectMany(SN => SN.ToCharArray());
            #endregion
            #region Set Operators
            var Seq01 = Enumerable.Range(0, 100);
            var Seq02 = Enumerable.Range(50, 100);
            #region Index , Range C# 8.0
            //var Lst1 = Seq01.ToList();
            //Console.WriteLine(Lst1[0]);
            //Console.WriteLine(Lst1[^1]);///Last Element
            //Console.WriteLine(Lst1[^5]);///Ffith Last Element
            //Range Result = 1..10;
            //int[] Arr = { 1, 2, 3, 4, 5, 6, 7 };
            //int R = Arr[0];
            //R = Arr[^1];
            //var L = Arr[1..3];
            //var L02 = Arr[100 ^ 3];

            #endregion

            //var Result = Seq01.Union(Seq02);//remove duplicates

            //Result = Seq01.Concat(Seq02);//allow duplicates
            //Result = Result.Distinct();// Concat + Distinct = Union

            //Result = Seq01.Except(Seq02);//in Seq01 and not in Seq02
            //Result = Seq01.Intersect(Seq02);//in Seq01 and in Seq02

            //foreach (var item in Result)
            //    Console.Write($"{item} , ");

            #endregion
            #region Quantifiers , return Boolean
            // Console.WriteLine(
            //ProductList.Any() // return true if input sequence have at least one element
            //ProductList.Any(P=>P.UnitsInStock>200) // return true if input sequence have at least one element Matching Predicate
            //ProductList.All(P=>P.UnitsInStock >0)//return true if all elements match predicate
            //Seq01.SequenceEqual(Seq02)
            // ) ;

            #endregion
            #region Zip
            ///Input  2 Seq , one Combined O/P Seq
            //var Lst02 = Enumerable.Range(0, 10);
            //var Result = NameList.Zip(Lst02,(FN,i)=> new {i,Name = FN.ToUpper() });
            #endregion
            #region Grouping
            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into PrdGroup
            //             where PrdGroup.Count() >= 5
            //             orderby PrdGroup.Count() descending
            //             //select PrdGroup;
            //             select new { Category = PrdGroup.Key, PrdGroupCount = PrdGroup.Count() };

            //foreach (var PrdGroup in Result)
            //{
            //    Console.WriteLine($"Group Key {PrdGroup.Category} : Group Count {PrdGroup.Count()}");
            //    foreach (var Prd in PrdGroup)  
            //    {
            //        Console.WriteLine($".. {Prd.ProductName}");
            //    }
            //}
            #endregion
            #region Let \ Into - Introducong new Range Variable Query
            List<string> Names = new List<string>()
            {
                "Ahmed","Aly","Mai","Sally","Moemen","Shimaa","Mohammed"

            };
            ///aoieuAOIEU

            ///Regular Expression

            //var Result = from N in Names
            //             select Regex.Replace(N, "[aoieuAOIEU]", String.Empty)
            //             ///Restart Query with new Range Variable , Old Range Variable is npt Accessible
            //             into NoVol
            //             where NoVol.Length >= 3
            //             orderby NoVol // Can't access the main Names
            //             select NoVol;
            //var Result = from N in Names
            //             let NoVol =  Regex.Replace(N, "[aoieuAOIEU]", String.Empty)
            //             ///Let , Continue Query with added Range Variable
            //             where NoVol.Length >= 3
            //             orderby NoVol, N.Length descending // Can access the main Names
            //             select NoVol;
            #endregion


            //foreach (var item in Result)
            //    Console.WriteLine(item);

        }
    }
}
