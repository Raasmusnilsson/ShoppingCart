using System.Collections.Generic;

namespace ShoppingCart
{
    interface IDiscount
    {
        double DiscountPrice(List<Item> cartItems);
    }

}
