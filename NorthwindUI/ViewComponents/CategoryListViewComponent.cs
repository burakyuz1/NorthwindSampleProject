using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using NorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindUI.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent //ViewComponent Inheritance
    {
        ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke() // ViewComponent kullanımı için ViewViewComponentResult classını kullanmam ve ismine Invoke() vermem gerekli..
        {
            var model = new CategoryListViewModel()
            {
                Categories = _categoryService.GetCategories(),
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["category"]) //QUERY STRING OKUMA <-------
            };
            return View(model);
        }
    }
}
