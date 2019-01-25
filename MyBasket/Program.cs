using MyBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBasket
{
    class Program
    {
        static void Main(string[] args)
        {

            var basket = new Basket();



            var tshirt = new T_Shirt();
            tshirt.Name = "Puma";
            tshirt.Size = Product_Size.Large;
            //Product test = tshirt;           
            basket.Products.Add(tshirt);

            var golfer = new Golfer();
            golfer.Name = "Adidas";
            golfer.Size = Product_Size.Medium;
            basket.Products.Add(golfer);

            var formalPants = new Jeans();
            formalPants.Name = "Reebok";
            formalPants.Size = Product_Size.Small;
            basket.Products.Add(formalPants);

            var jeans = new Formal_Pants();
            jeans.Name = "Nike";
            jeans.Size = Product_Size.Large;
            basket.Products.Add(jeans);



            Console.WriteLine($"Your total price is R{basket.GetTotalPrice()}");
            Console.Read();
            //Total to be expected is R140
        }
    }
}
