namespace SimpleApp.Models;

public interface IDataSource
{
    public IEnumerable<Product> Products { get; }
}