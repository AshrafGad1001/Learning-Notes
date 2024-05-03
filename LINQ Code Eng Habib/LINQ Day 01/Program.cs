using L2O___D09;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static L2O___D09.ListGenerators;
////Dy01
////  - C# is a Strongly Typed Language , Statically Typed Languaged 
////  - Most of LINQ Operators , Deffered Execution 
////  - LinQ Queries Against any Sequence
////  - Sequence : Class Implementing IEnumerable<T> Interface

////  - Local Sequence : L2O , L2ADO , L2XML
////  - Remote Sequence : L2sql , L2E
////  - Sequence Contains Elements 

///// - Sql Like Style , valid for only Subset of (40+ LINQ Operators)
///// - Some cases it is easier to write Query using Query Expression vs Fluent Syntax ( Join , Group , Let , Into)
///// - Start with From , introduce Range Variable (i) : represent each and every element in Input Sequence
///// - End with Select or Group By 

////Day02  -- Linq To Object
//// Static Using ->'using static L2O___D09.ListGenerators;'
///

namespace LINQ_Day_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicit Typed Local Variable 
            //var D = 123.456;

            //Console.WriteLine(D.GetType());

            ////D = "Hello"; /// Not Valid , C# is a Strongly Typed Language , Statically Typed Languaged 

            #endregion
            #region Anonymous Type
            ////Employee E1 = new Employee() { ID = 101, Name = "Aly", Salary = 5000 };

            ////Console.WriteLine(E1.GetType().Name);

            ////Console.WriteLine(E1);

            ////Employee E2 = new Employee() { ID = 101, Name = "Aly", Salary = 5000 };

            ////if ( E1.Equals(E2))
            ////    Console.WriteLine("Value EQ");

            /////Anonymous Type
            //var E1 = new { ID = 101, Name = "Aly", Salary = 5000M };

            //Console.WriteLine(E1.GetType().Name);
            ////Console.WriteLine(E1.GetType().FullName);
            //Console.WriteLine(E1);

            ////E1.Name = "Samir"; ///Immutable Object

            //var E2 = new { ID = 102, Name = "Tamer", Salary = 7000M };
            /////Same DT as long as Same Property Names (With same Charcter Case) , same Property Type , same Sequence
            //Console.WriteLine(E2.GetType().Name);


            //var E3 = new { ID = 102,  Salary = 7000M , Name = "Tamer"};
            /////new Anonymous Data Type
            /////
            //Console.WriteLine(E3.GetType().Name);
            //var E4 = new { ID = 101, Name = "Aly", Salary = 5000M };

            //if ( E1.Equals(E4))
            //    Console.WriteLine("Value EQ");

            //Console.WriteLine(E1.GetHashCode());
            //Console.WriteLine(E4.GetHashCode());

            /////GetHashCode based on Values not Identity

            //var P1 = new { ProductID = 5, ProductName = "Pens" };

            //Console.WriteLine(P1.GetType()); 
            #endregion
            #region Day01 part2
            //List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<string> lst2 = new List<string>() { "Ashraf Gad", "Ahmed Gad", "Sally Salah", "Sayed", "Ahmed Aly" };


            //// IEnumerable<int> Result = Enumerable.Where(lst, i => i % 2 == 0);


            ////Fluent Syntax
            //var Result = Enumerable.Where(lst, i => (i % 2 == 0));

            //var Result2 = lst.Where(i => (i % 2 == 0));

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            ////Query Synax--> like SQL

            //var RR = from i in lst
            //         where (i % 2 == 0)
            //         select i;

            /////Sql Like Style , valid for only Subset of (40+ LINQ Operators)
            /////Some cases it is easier to write Query using Query Expression vs Fluent Syntax ( Join , Group , Let , Into)
            /////Start with From , introduce Range Variable (i) : represent each and every element in Input Sequence
            /////End with Select or Group By 

            //foreach (var item in RR)
            //{
            //    Console.WriteLine(item);
            //}


            ///Most of LINQ Operators , Deffered Execution  
            #endregion
            #region Where -- Filteration 
            ////Fluent Syntax

            //  var RR = ProductList.Where(i => i.UnitsInStock == 0);

            ////Query Synax--> like SQL

            //var RR = from i in ProductList
            //         where i.UnitsInStock == 0
            //         select i;


            #endregion
            #region Select : Transformation Operatorct
            ////Project\Transform every Element in Input Seq to A new Element in Output Seq of New DataType(or same Type)


            ////Different Data Type  
            ///product   -> String 


            //var RR = ProductList.Select(p => p.ProductName);


            //RR = from p in ProductList
            //     select (p.ProductName);

            //Anonymous Type from Product List 



            //var RR = ProductList.Where(p => p.UnitsInStock == 0)
            //                    .Select(p => new { ID = p.ProductID, Name = p.ProductName });


            //var Disc_lst = ProductList.Select(p => new Product()
            //{
            //    ProductName = p.ProductName,
            //    ProductID = p.ProductID,
            //    Category = p.Category,
            //    UnitsInStock = p.UnitsInStock,
            //    UnitPrice = p.UnitPrice * 0.9M
            //}).Where(p => p.UnitsInStock == 0);


            //Disc_lst = from p in ProductList
            //           select new Product()
            //           {
            //               ProductName = p.ProductName,
            //               ProductID = p.ProductID,
            //               Category = p.Category,
            //               UnitsInStock = p.UnitsInStock,
            //               UnitPrice = p.UnitPrice * 0.9M
            //};










            ///Indexed Select , Valid Only in Fluent Syntax Format  00:34 min


            //var RR = ProductList.Where(p => p.UnitsInStock == 0)   ///O/P of Where Seq of 5 elements
            //                   .Select((p, i) => new { index = i, Product_Name = p.ProductName });

            //var RR = ProductList.Select(P => new { Name = P.ProductName, NewPrice = P.UnitPrice * 1.5M })
            //                    .Where(P => P.NewPrice > 20);


            //var R01 = ProductList.Select(P => new { Name = P.ProductName, NewPrice = P.UnitPrice * 1.5M });
            //var R02 = R01.Where(P => P.NewPrice > 20);



            //var RR1 = from P in ProductList
            //          select new { Name = P.ProductName, NewPrice = P.UnitPrice * 1.5M };

            //var RR2 = from p in RR1
            //          where p.NewPrice > 20
            //          select p;


            //var RR_into = from P in ProductList
            //              select new { Name = P.ProductName, NewPrice = P.UnitPrice * 1.5M }
            //              into newTaxedPrductList///new Range Variable to Continue Query using New(Only) Range Variable
            //              where newTaxedPrductList.NewPrice > 20
            //              select newTaxedPrductList;



            #endregion
            #region Ordering elements


            //var RR = ProductList.OrderBy(p => p.UnitsInStock);

            //var RR = from p in ProductList
            //         orderby p.UnitPrice
            //         where p.UnitPrice > 50
            //         select new { Name = p.ProductName, Price = p.UnitPrice };



            //var RR01 = ProductList.OrderByDescending(p => p.UnitPrice)
            //                      .ThenBy(p => p.UnitsInStock)
            //                      .Where(p => p.UnitsInStock != 0 )
            //                       .Select(p => new { Name = p.ProductName, Price = p.UnitPrice });

            #endregion
            #region Element Operators - Imidiate Execution


            //var RR01 = ProductList.First();

            //var RR02 = ProductList.Last();

            //var RR03 = ProductList.First(p => p.UnitsInStock == 0);

            //var RR04 = ProductList.Last(p => p.UnitsInStock == 0);


            //List<Product> DiscountedLst = new List<Product>(); ///Empty Sequence 

            /////if Input Seq have no elements , Throw Exception
            //var RR = DiscountedLst.First();
            //Console.WriteLine(RR);



            //var Result = DiscountedLst.FirstOrDefault();    ////LastOrDefault();
            /////return first element in Input Seq , return Default value if Empty Seq
            /////No Exception will be thrown
            //Console.WriteLine(Result?.ProductName??"No Item In List");




            /////Hybrid Syntax (Query Expression).Fluent Syntax

            //var RR = (from p in ProductList
            //          where p.UnitsInStock == 0
            //          select new { p.ProductName, p.UnitsInStock }).FirstOrDefault();




            //var Result = ProductList.ElementAt(14);







            //var Result = ProductList.Single();

            //return Single Element in Seq(Only One element in Input Seq)
            // Throw excption if Empty Seq or More than one element exists





            //Result = ProductList.Single(P => P.ProductID == 7);
            /////Throw Exception if More than one Product Matched Predicate or if No elements Matchs Predicate
            #endregion
            #region Aggregate - Imidiate Execution


            //var Result1 = ProductList.Count();
            //var Result2 = ProductList.Count(p => p.UnitsInStock == 0);


            //var Result3 = ProductList.Max(p => p.UnitPrice);
            //var Result4 = ProductList.Max();
            /////return Product : Max (Based on IComparable\<T> Implementation) Product
            ///  -> when Implementation IComparable\<T>


            //Console.WriteLine(Result1);
            //Console.WriteLine(Result2);
            //Console.WriteLine(Result3);
            //Console.WriteLine(Result4);

            #endregion
            #region Generators Operators 
            ///Generating Output Seq 
            ///Only way to call them is as static Members from Enumerable Class

            //var RR = Enumerable.Range(0, 10);

            //var R01 = Enumerable.Empty<Product>();

            //var R02 = Enumerable.Repeat(3, 10);


            //var Result = Enumerable.Repeat(ProductList[2], 5);



            #endregion
            #region Select Many 
            ///////Output Seq count > Input Seq Count
            ///////transform each element in input Seq to sub Seq (IEnumerable<>)


            //List<String> NameList = new List<string>() { "Ahmed Aly", "Sally Samir", "Taha Tamer" };

            //var Result = NameList.SelectMany(FullName => FullName.Split(' '));

            ///////Query Syntax : use Multiple from to product Select Many
            //Result = from FN in NameList
            //         from SN in FN.Split(" ")
            //         select SN;
            #endregion
            #region Casting Operator

            //List<Product> UnAvaiable = ProductList.Where(p => p.UnitsInStock == 0).ToList();

            //Product[] PArr = ProductList.Where(p => p.UnitsInStock == 0).OrderBy(p => p.UnitPrice).ToArray();









            #endregion
            #region Set Operator 


            //var Lst01 = Enumerable.Range(0, 100); /// 0..99
            //var Lst02 = Enumerable.Range(50, 100); ///50..149

            //var Lst1 = Lst01.ToList();

            //Console.WriteLine(Lst1[0]);
            //Console.WriteLine(Lst1[^1]);/// => Last Element.
            //Console.WriteLine(Lst1[^5]);/// => Element 5 from Last.


            //var Result = Lst01.Union(Lst02);//Remove Duplicate Data


            //var Result = Lst01.Concat(Lst02);


            //var Result = Lst01.Intersect(Lst02);

            //var Result = Lst01.Except(Lst02);


            #endregion
            #region Quantifiers , return Boolean


            ////var Seq01 = Enumerable.Range(0, 100); /// 0..99
            ////var Seq02 = Enumerable.Range(50, 100); ///50..149


            ////Console.WriteLine(ProductList.Any());
            //////return true if input Seq have at least one element

            ////Console.WriteLine(ProductList.Any(P => P.UnitPrice > 200));
            /////// return true if input Seq have at least one element Mathcing Predicate

            ////Console.WriteLine(ProductList.All(P => P.UnitsInStock > 0));
            ///////return true of ALL Elemenets in Input Seq Match Predicate

            ////Console.WriteLine(Seq01.SequenceEqual(Seq02));

            #endregion
            #region ZIP operator 
            /////Input 2 Seq , one Combined O/p Seq


            //var lst01 = Enumerable.Range(0, 10);
            //List<String> NameList = new List<string>() { "Ahmed Aly", "Sally Samir", "Taha Tamer" };



            //var RR = NameList.Zip(lst01, (FN, i) => new { i, Name = FN.ToUpper() });
            #endregion
            #region Grouping 
            //var RR = from p in ProductList
            //         where p.UnitsInStock > 0
            //         group p by p.Category;



            //foreach (var ProductGroup in RR)
            //{
            //    Console.WriteLine($"Group Key : {ProductGroup.Key}");
            //    foreach (var product in ProductGroup)
            //    {
            //        Console.WriteLine($"......{product.ProductName}  {product.UnitsInStock}");
            //    }
            //}

            #endregion

            #region Let \ Into - Introducing new Range Variable in Query Syntax

            List<string> Names = new List<string>()
            {
                "Ahmed",
                "Aly",
                "Mai",
                "Sally",
                "Moemen",
                "Shimaa",
                "Mohammed"
            };

            //var RR = from n in Names
            //         select Regex.Replace(n, "[aoieuAOIEU]", string.Empty)
            ////Restart Query with new Range Variable , Old Range Variable is not Accessable
            //         into NoVol
            //         where NoVol.Length >= 3
            //         select NoVol;




            ///Let , Continue Query with added Range Variable 
            var RR = from n in Names
                     let NoVol = Regex.Replace(n, "[aoieuAOIEU]", string.Empty)
                     where NoVol.Length >= 3
                     select NoVol;
            #endregion


            foreach (var item in RR)
            {
                Console.WriteLine(item);
            }
        }
    }
}