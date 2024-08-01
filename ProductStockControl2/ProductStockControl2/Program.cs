using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStockControl2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Market m = new Market();
            string devam = "e";
            double total = 0;
            while (devam == "e")
            {
                m.marketList();

                Console.WriteLine("Almak istediğiniz ürünün kodunu giriniz = ");
                int buy = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kaç adet almak istediğinizi giriniz = ");
                int piece = Convert.ToInt32(Console.ReadLine());

                if (m.products[buy-1].stock >= 0)
                {
                    m.stockReduction(buy, piece);
                    total += m.cart(buy, piece);
                }
                else
                {
                    Console.WriteLine("Stokta olmayan ürünü alamazsınız.");
                }
                Console.WriteLine("Alışverişe devam etmek istiyor musunuz?");
                devam = Console.ReadLine();

            }
            Console.WriteLine("Toplam tutarınız = " + total);
            Console.ReadKey();
        }
    }
}
