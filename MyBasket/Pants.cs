using MyBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBasket
{
    public class Pants : Product
    {
        public Pants()
        {
        }

        protected Pants(string name, Product_Size size) //Protected encapsulation used to
                                                        //access to members of same class
                                                        //and the derived classes of Shirt
        {
            Name = name;
            Size = size;
        }



        public override double DefaultPrice() //Overriding the abstract method in parent class
        {
          
            double total = (double) Size;
            return total;
        }
    }
}
