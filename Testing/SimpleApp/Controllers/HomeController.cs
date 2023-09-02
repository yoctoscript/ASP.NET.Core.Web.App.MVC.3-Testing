using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
namespace SimpleApp.Controllers;


public class HomeController : Controller
{
    public IDataSource _productDataSource = new ProductDataSource();
    public IActionResult Index()
    {
        return View(_productDataSource.Products);
    }
}