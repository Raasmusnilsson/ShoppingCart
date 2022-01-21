using System;

namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new();
            
            Item garlic = new("Garlic", 43, 1);
            Item thyme = new("Thyme", 35, 2);
            Item ribeye = new("Ribeye Entrecôte",439.5, 3);
            Item butter = new("French butter", 189, 4);

            cart.AddItem(garlic);
            cart.AddItem(garlic);
            cart.AddItem(garlic);
            cart.AddItem(thyme);
            cart.AddItem(ribeye);
            cart.AddItem(butter);
            cart.AddItem(ribeye);
            //cart.RemoveItem(garlic);

            DiscountTenPercent discountTen = new();
            DiscountThreeForTwo discountThreeForTwo = new();
            DiscountCheapestFree discountCheapestFree = new();

            Console.WriteLine("Total Price in Cart: "+ ShoppingCart.GetTotalPriceOfCart(cart.GetItems())); 

            discountTen.DiscountPrice(cart.GetItems());
            discountThreeForTwo.DiscountPrice(cart.GetItems());
            discountCheapestFree.DiscountPrice(cart.GetItems());

        }
    }

}
