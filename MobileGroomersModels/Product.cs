namespace MobileGroomersModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; } //its how many times we can provide service per day.

        public Product()
        {
            Id = 0;
            Name = "Default";
            Price = 0;
            Quantity = 0;
        }
    }
}