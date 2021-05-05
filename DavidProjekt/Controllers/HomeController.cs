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
        private readonly ICourseService _courseService;

        public HomeController(ICategoryService categoryService, ICourseService courseService)
        {
            _categoryService = categoryService;
            _courseService = courseService;
        }

        public IActionResult Index(HomePageViewModel model)
        {
            var categories = _categoryService.GetAll();
            var categoriesVm = new List<CategoryViewModel>();
            var popularCourses = _courseService.GetMostPopularCourses();
            var coursesVm = new List<CoursesViewModel>();
            foreach (var item in popularCourses)
            {
                coursesVm.Add(new CoursesViewModel { Id = item.Id, ImageUrl = item.ImageUrl, IsPopular = item.IsPopular, Tags = item.Tags, Title = item.Title });
            }
            foreach (var item in categories)
            {
                categoriesVm.Add(new CategoryViewModel { Id = item.Id, Name = item.Name });
            }

            model.Categories = categoriesVm;
            model.Courses = coursesVm;
            return View(model);
        }

    }
}
