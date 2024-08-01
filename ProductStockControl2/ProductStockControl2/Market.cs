using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductStockControl2
{
    internal class Market
    {
        public Product[] products;

        public Market()
        {
            products = new Product[3];

            Product prod1 = new Product();
            prod1.id = 1;
            prod1.name = "Tomatoes";
            prod1.price = 1;
            prod1.stock = 20;
            prod1.category = "Vegatables";

            Product prod2 = new Product();
            prod2.id = 2;
            prod2.name = "Strawberry";
            prod2.price = 3.15;
            prod2.stock = 30;
            prod2.category = "Fruits";

            Product prod3 = new Product();
            prod3.id = 3;
            prod3.name = "Watermelon";
            prod3.price = 2.75;
            prod3.stock = 30;
            prod3.category = "Fruits";

            products[0] = prod1;
            products[1] = prod2;
            products[2] = prod3;
        }

        public void marketList()
        {

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].stock > 0)
                {
                    Console.WriteLine(products[i].id + ") \t" + products[i].name + "\t" + products[i].price + "\t" + products[i].stock + "\t" + products[i].category);
                }
                else
                {
                    Console.WriteLine(products[i].id + ") \t" + products[i].name + "\t" + "Stok kalmamıştır.");
                }

            }
        }
        public void stockReduction(int p_productid, int p_piece)
        {
            int index = p_productid - 1;
            products[index].stock -= p_piece;
        }
        public double cart(int p_productid, int p_piece)
        {
                int index = p_productid - 1;
                return products[index].price * p_piece;
          
        }
        
    }
}
