namespace ShoppingCart
{
    public class Item
    {
        public Item(string name, double price, int articleNumber)
        {
            Name = name;
            Price = price;
            ArticleNumber = articleNumber;
        }
        public int ArticleNumber { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


    }

}
