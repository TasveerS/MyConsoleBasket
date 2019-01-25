using MyBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBasket
{
    public class T_Shirt : Shirt
    {
        public T_Shirt() : base()
        {
        }

        public T_Shirt(string name, Product_Size size) : base(name, size)
        {
        }

        public override double DefaultPrice()
        {


            double total = base.DefaultPrice();




            return total;

        }

    }

}
