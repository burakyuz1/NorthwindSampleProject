using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using NorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindUI.Controllers
{
    public class CategoryController :Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

    
    }
}
