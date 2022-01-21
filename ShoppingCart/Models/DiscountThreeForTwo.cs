using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class DiscountThreeForTwo : IDiscount
    {
        public double DiscountPrice(List<Item> cartItems)
        {
            
            List<Item> SortedList = cartItems.OrderBy(item => item.ArticleNumber).ToList();
            List<Item> Matches = new();
            double price = 0;
            double total = 0;

            foreach (Item item in cartItems)
            {
                price += item.Price;
            }

            foreach (Item item in SortedList)
            {
               Matches = cartItems.Where(p => p.ArticleNumber == item.ArticleNumber).ToList();
                if(Matches.Count == 3)
                {
                    total = price - item.Price;
                    Console.WriteLine("Price with 3 for 2 Discount: " + total);
                    return total;
                }

            }
            return price;
        }
    }

}
