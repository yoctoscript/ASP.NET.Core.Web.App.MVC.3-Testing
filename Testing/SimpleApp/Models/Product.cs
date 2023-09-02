
namespace SimpleApp.Models;

public class Product
{
    public string Name { get; set; } = String.Empty;
    public decimal? Price { get; set; }
    /*public static Product[] GetProducts()
    {
        Product[] products = new Product[]
        {
            new Product {Name = "Kayak", Price = 275m},
            new Product {Name = "LifeJacket", Price = 48.95m}
        };
        return products;
    }*/
}

public class ProductDataSource : IDataSource
{
    public IEnumerable<Product> Products => new Product[]
    {
        new Product { Name = "Kayak", Price = 275m},
        new Product { Name = "LifeJacket", Price = 48.95m}
    };
}