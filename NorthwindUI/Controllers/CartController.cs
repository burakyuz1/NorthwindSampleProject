using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.DomainModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindUI.Helpers;
using NorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindUI.Controllers
{
    public class CartController : Controller
    {
        ICartSessionHelper _cartSessionHelper;
        ICartService _cartService;
        IProductService _productService;

        public CartController(ICartSessionHelper cartSessionHelper, ICartService cartService, IProductService productService)
        {
            _cartSessionHelper = cartSessionHelper;
            _cartService = cartService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            var model = new CartlistViewModel()
            {
                Cart = _cartSessionHelper.GetCart("cart")
            };
            return View(model);
        }
        public IActionResult AddToCart(int id)
        {
            Product product = _productService.GetProductById(id);
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.AddToCart(cart, product);
            _cartSessionHelper.SetToCart("cart", cart);
            TempData.Add("Message", product.ProductName + " has been added to your cart!");
            return RedirectToAction("Index", "Product");
        }
        public IActionResult RemoveFromCart(int id)
        {
            Product product = _productService.GetProductById(id);
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.RemoveFromCart(cart,id);
            _cartSessionHelper.SetToCart("cart", cart);
            TempData.Add("Message", product.ProductName + " has been removed from your cart!");
            return RedirectToAction("Index");
        }



    }
}
