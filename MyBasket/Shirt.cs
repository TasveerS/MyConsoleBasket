using MyBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBasket
{
    public class Shirt : Product
    {
        public Shirt()
        {
        }

        protected Shirt(string name, Product_Size size) //Protected encapsulation used to
                                                        //access to members of same class
                                                        //and the derived classes of Shirt
        {
            Name = name;
            Size = size;
        }



        public override double DefaultPrice()
        {

            double total = (double)Size;

            //if (Size=="s")
            //{
            //    total = total + 10;
            //}
            //else
            //{
            //    if (Size=="m")
            //    {
            //        total = total + 20;
            //    }
            //    else
            //    {
            //        if (Size == "l")
            //        {
            //            total = total + 30;
            //        }
            //    }
            //}
            return total;
        }
    }
}
