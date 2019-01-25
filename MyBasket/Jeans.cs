using MyBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBasket
{
    public class Jeans : Pants
    {
        public Jeans()
        {
        }

        public Jeans(string name, Product_Size size) : base(name, size)
        {
        }



        public override double DefaultPrice()
        {
            double total = base.DefaultPrice();

            return total;
        }
    }
}
