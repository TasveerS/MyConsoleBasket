using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBasket
{
    public class Basket
    {
       // public List<Shirt> Shirts { get; set; } // Used lists as it can grow in size compared to an array
                                                // therefore will allow more items to be added to basket
        // public List<Pants> Pants { get; set; }
        public List<Product> Products { get; set; } //Pants and Shirts are both products, easier
                                                    // to use one list to total both the products instead of 2 separate lists.


        public Basket()
        {
            Products = new List<Product>();
        }
        public double GetTotalPrice()
        {
            double total = 0;
            
            foreach (var product in Products)
            {
                var test = product.DefaultPrice();       //testing to see each object in the list 
            }
            total = Products.Sum(x => x.DefaultPrice()); //Totalling my items in my list

           

            return total;
        }

    
    }
}
