using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SimpleApp.Controllers;
using SimpleApp.Models;
using Xunit;
using Moq;

namespace SimpleApp.Tests;

public class HomeControllerTests
{
    /*class FakeDataSource : IDataSource
    {
        public FakeDataSource(Product[] data) => Products = data;
        public IEnumerable<Product> Products { get; set; }
    }*/
    [Fact]
    public void IndexActionModelIsComplete()
    {
        // Arrange.
        Product[] testData = new Product[]
        {
            new Product {Name = "Kayak", Price = 275m},
            new Product {Name = "LifeJacket", Price = 48.95m}
        };
        var mock = new Mock<IDataSource>();
        mock.SetupGet(m => m.Products).Returns(testData);
        HomeController homeController = new();
        homeController._productDataSource = mock.Object;

        // Act.
        IEnumerable<Product>? model = (homeController.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product> ;
    
        // Assert
        Assert.Equal(testData, model, Comparer.Get<Product>((p1, p2) => p1?.Name == p2?.Name && p1?.Price == p2?.Price));
        mock.VerifyGet(m => m.Products, Times.Once);
    }
}