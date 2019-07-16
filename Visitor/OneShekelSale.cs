using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class OneShekelSale : IVisitor
    {
        public double Visit(Liquor liquor)
        {
            return liquor.Price =1;
        }

        public double Visit(Tabacco tabacco)
        {
            return tabacco.Price = 1;
        }

        public double Visit(Chocolate chocolate)
        {
            return chocolate.Price = 1;
        }

        public double Visit(perfume perfume)
        {
            return perfume.Price = 1;
        }
        public double Visit(ShopRent shopRent)
        {
            return shopRent.Price =1;
        }

    }
}
