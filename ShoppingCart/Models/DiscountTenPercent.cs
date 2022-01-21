using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    public class DiscountTenPercent : IDiscount
    {
        
        public double DiscountPrice(List<Item> cartItems)
        {
            double price = 0.0;
            double total = 0.0;
            
            foreach (Item item in cartItems)
            {
                 price += item.Price;
                 total += item.Price;
            }
            if(total > 500) {
                price = total * 0.9;
                Console.WriteLine("Price with 10% Discount: " + (int)price * 0.9M);
                return price;
            }
            else { Console.WriteLine("Price: " + total);
                return total; 
            }
            
            
        }

    }

}
