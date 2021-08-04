using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using NorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int category)
        {
            var model = new ProductListViewModel()
            {
                Products = category > 0 ? _productService.GetProducts(category) : _productService.GetProducts(),
            };
            return View(model);
        }
    }
}
