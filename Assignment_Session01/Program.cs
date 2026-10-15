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

            var ProductName = ProductList
               .Select(p => new { p.ProductName});

            foreach(var p in ProductName)
            { Console.WriteLine($"Product Name: {p.ProductName}"); }

            #endregion
        }
    }
}
