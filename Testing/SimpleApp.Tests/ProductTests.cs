using SimpleApp.Models;
using Xunit;

namespace SimpleApp.Tests;

public class ProductTests
{
    [Fact]
    public void CanChangeProductName()
    {
        // Arrange.
        Product product = new Product {Name="Test", Price = 100m};

        // Act
        product.Name = "New name";

        // Assert
        Assert.Equal("New name", product.Name);
    }

    [Fact]
    public void CanChangeProductPrice()
    {
        // Arrange
        Product product = new Product {Name="Test", Price = 100m};

        // Act
        product.Price = 0m;

        // Assert
        Assert.Equal(0m, product.Price);
    }
}