using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart
{
    public class PotterShoppingCart
    {
        public double Calculate_Price(List<Book> books)
        {
            double price = 0;
            price = books.Sum(x => x.Price);
 
            return price;
        }

        private double Get_discount(int count)
        {
            double discount = 1;

            switch (count)
            {
                case 2:
                    discount = 0.95;
                    break;
                case 3:
                    discount = 0.9;
                    break;
                case 4:
                    discount = 0.8;
                    break;
                case 5:
                    discount = 0.75;
                    break;
                default:
                    break;
            }
            return discount;
        }
    }
}
