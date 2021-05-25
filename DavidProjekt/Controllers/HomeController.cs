using DavidProjekt.Data.Models;
using DavidProjekt.Models;
using DavidProjekt.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DavidProjekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ICourseService _courseService;
        private readonly ISubscriptionService _subscriptionService;
        private readonly UserManager<User> _usermanager;

        public HomeController(ICategoryService categoryService, ICourseService courseService, ISubscriptionService subscriptionService, UserManager<User> usermanager)
        {
            _categoryService = categoryService;
            _courseService = courseService;
            _subscriptionService = subscriptionService;
            _usermanager = usermanager;
        }

        public IActionResult Index(HomePageViewModel model)
        {
            var categories = _categoryService.GetAll();
            var categoriesVm = new List<CategoryViewModel>();
            var popularCourses = _courseService.GetMostPopularCourses();
            var coursesVm = new List<CoursesViewModel>();
            string userId = string.Empty;
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                var username = HttpContext.User.Identity.Name;
                userId = _usermanager.GetUserAsync(HttpContext.User).Result.Id;
            }
            foreach (var item in popularCourses)
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {

                    coursesVm.Add(new CoursesViewModel { IsSubbed = _subscriptionService.IsSubscribed(item.Id, userId), Id = item.Id, ImageUrl = item.ImageUrl, IsPopular = item.IsPopular, Tags = item.Tags, Title = item.Title });
                }
                else
                {
                    coursesVm.Add(new CoursesViewModel { Id = item.Id, ImageUrl = item.ImageUrl, IsPopular = item.IsPopular, Tags = item.Tags, Title = item.Title });

                }
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
