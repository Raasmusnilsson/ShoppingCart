using System.Collections.Generic;

namespace ShoppingCart
{
    public class ShoppingCart
    {
        private readonly List<Item> items = new();

        public void AddItem(Item item)
        {
            items.Add(item);
            
        }

        public List<Item> GetItems()
        {
            foreach (Item item in items)
            {
                //Console.WriteLine("Item name: " + item.Name + ", Price: " + item.Price + ".");
            }
            return items;
        }
        public void RemoveItem(Item item) { items.Remove(item); }

        public static double GetTotalPriceOfCart(List<Item> cartItems)
        {
            double total = 0.0;

            foreach (Item item in cartItems)
            {
                total += item.Price;
            }
            return total;
        }


    }

}
