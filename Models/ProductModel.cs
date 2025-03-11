namespace SimpleWebApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        // Use 'required' to enforce non-nullable properties
        public required string Name { get; set; }

        public decimal Price { get; set; }

        // Primary constructor
        public ProductModel(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}