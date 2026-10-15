using Assignment_Session01.Models;
using System.Drawing;
using System.Xml.Linq;
using static Assignment_Session01.DataSources.Source;

namespace Assignment_Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //1.Get all products from the "Seafood" category.
            //Print each product's name and price.

            //var seafoodproduts = ProductList
            //    .Where(p => p.Category == "Seafood")
            //   .Select(p => new { p.ProductName, p.UnitPrice });

            //foreach (var p in seafoodproduts)
            //{ Console.WriteLine($"Product Name: {p.ProductName}, Price: {p.UnitPrice:C2}"); }
            #endregion

            #region Q02
            //2.Get a list of only the product names from ProductList.
            // Print each name.

            //var ProductName = ProductList
            //   .Select(p => new { p.ProductName});

            //foreach(var p in ProductName)
            //{ Console.WriteLine($"Product Name: {p.ProductName}"); }

            #endregion

            #region Q03
            //3.Get all products where UnitPrice is between 10 and 30

            //var productsBetween10and30 = ProductList
            //    .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30)
            //    .Select(p => new { p.ProductName, p.UnitPrice });

            //foreach (var p in productsBetween10and30)
            //{ Console.WriteLine($"Product Name: {p.ProductName} ||  Price: {p.UnitPrice:C2}"); }
            #endregion

            #region Q04
            //4.Get all products that are in stock(UnitsInStock >0) and belong to the "Condiments" category.
            //var Spices_Condimentsproduts = ProductList
            //    .Where(p => p.Category == "Spices & Condiments" && p.UnitsInStock > 0)
            //   .Select(p => new { p.ProductName, p.UnitsInStock });

            //foreach (var p in Spices_Condimentsproduts)
            //{Console.WriteLine($"Product Name: {p.ProductName} || Units in Stock: {p.UnitsInStock}");}
            #endregion

            #region Q05
            //5.Create a new anonymous type with three
            //properties: ● Name → the product name
            //● Price → the unit price
            //● StockStatus → a string: "Available" if
            //UnitsInStock > 0, otherwise "Out of Stock"
            //● Print the result.

            //var Products = ProductList
            //.Select(p => new { Name = p.ProductName, Price = p.UnitPrice, StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock" });

            //foreach (var p in Products)
            //{ Console.WriteLine($"Product Name: {p.Name} || Price: {p.Price:C2} || Stock Status: {p.StockStatus}");}



            #endregion

            #region Q06
            //6.Print each product's name along with its position
            //(1 - based) in the list. Expected format: 1.Chai, 2.
            //Chang, etc.

            //var ProductsIndex = ProductList
            //    .Select((p,i) => new { index=i , Name = p.ProductName } );

            //foreach (var p in ProductsIndex)
            //{ Console.WriteLine($" {p.index+1}.{p.Name}"); }
            #endregion
        }
    }
}
