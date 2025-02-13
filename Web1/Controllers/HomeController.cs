using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web1.context;
using Web1.Models;
using Web1.service;
using Web1.service.concrete;

namespace Web1.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index(int? id)
        {
            Console.WriteLine("ooo kral hg");

            List<CategoryModel> categories = _categoryService.GetAll();

            IndexModel indexModel = new IndexModel();
            indexModel.categories = categories;
            indexModel.products = _productService.getAllProducts(id);

            return View(indexModel);
         
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
