using MyBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBasket
{
    public abstract class Product
    {
        public Product()
        {
        }

        public string Name { get; set; }

        // public string Size { get; set; }           
        public Product_Size Size { get; set; }

        public abstract double DefaultPrice();

    }

}
