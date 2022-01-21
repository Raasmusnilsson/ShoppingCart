using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class DiscountCheapestFree : IDiscount
    {
        public double DiscountPrice(List<Item> cartItems)
        {
            List<Item> SortedList = cartItems.OrderBy(item => item.Price).ToList();
            double total = 0.0;
            double price = 0.0;

            if (SortedList.Count > 5)
            {
                SortedList.RemoveAt(0);
                foreach(Item item in SortedList)
                {
                     price += item.Price;       
                }
                Console.WriteLine("Price with cheapest for free: " + price);
                
                return price;
            }
            
            else { 
                foreach(Item item in cartItems)
                {
                    total += item.Price;
                }
                Console.WriteLine("Price without cheapest for free: " + total);
                return total; 
            }
        }
    }

}
