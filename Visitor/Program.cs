using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Liquor vodka = new Liquor(95);

            Console.WriteLine(vodka);

            IVisitor endOfYearVisitor = new EndOfYearTax();

            Console.WriteLine($"Price after tax = {vodka.Accept(endOfYearVisitor)}");

            IVisitor OneShekelvisitor = new OneShekelSale();

            Console.WriteLine($"Price after one shekel sale = {vodka.Accept(OneShekelvisitor)}");

            ShopRent shop = new ShopRent(100);
            
            Console.WriteLine($"Price after shop rent = {shop.Accept(OneShekelvisitor)}");
        }
    }
}
