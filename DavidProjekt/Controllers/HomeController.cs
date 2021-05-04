using DavidProjekt.Models;
using DavidProjekt.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DavidProjekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;

        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index(HomePageViewModel model)
        {
            var categories = _categoryService.GetAll();
            var categoriesVm = new List<CategoryViewModel>();

            foreach (var item in categories)
            {
                categoriesVm.Add(new CategoryViewModel { Id = item.Id, Name = item.Name });
            }

            model.Categories = categoriesVm;
            return View(model);
        }

    }
}
