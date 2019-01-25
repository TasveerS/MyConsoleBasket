using MyBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBasket
{
    public class Golfer : Shirt
    {
        public Golfer() : base()
        {
        }

        public Golfer(string name, Product_Size size) : base(name, size)
        {
        }


        public override double DefaultPrice()
        {
            double total = (base.DefaultPrice()) * 2;

            return total;
        }


    }

}
