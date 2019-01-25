using MyBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBasket
{
    public class Formal_Pants : Pants
    {
        public Formal_Pants()
        {
        }

        public Formal_Pants(string name, Product_Size size) : base(name, size) 
        {
        }


        public override double DefaultPrice()
        {
            double total = (base.DefaultPrice()) + 30; 

            return total;
        }
    }
}
