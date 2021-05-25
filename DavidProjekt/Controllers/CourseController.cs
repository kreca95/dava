using DavidProjekt.Data.Models;
using DavidProjekt.Helpers;
using DavidProjekt.Models;
using DavidProjekt.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Controllers
{
    [Route("[controller]")]

    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ISubscriptionService _subscriptionService;
        private readonly ICategoryService _categoryService;
        private readonly UserManager<User> _userManager;
        public CourseController(ICourseService courseService, UserManager<User> userManager, ICategoryService categoryService, ISubscriptionService subscriptionService)
        {
            _courseService = courseService;
            _userManager = userManager;
            _categoryService = categoryService;
            _subscriptionService = subscriptionService;
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var course = _courseService.Get(id);
            course.Lectures = course.Lectures.OrderBy(x => x.OrderNum).ToList();
            return View(course);
        }

        [HttpGet]
        [Authorize(Roles = "admin")]

        public IActionResult Index()
        {
            var courses = _courseService.GetAll();
            List<CourseViewModel> model = new List<CourseViewModel>();
            foreach (var item in courses)
            {
                model.Add(new CourseViewModel
                {
                    Description = item.Description,
                    Duration = item.Lectures.Sum(x => x.Length),
                    Id = item.Id,
                    ImageUrl = item.ImageUrl,
                    Name = item.Title,
                    Tags = item.Tags,
                    VideoCount = item.Lectures.Count,
                    Category = item.Category.Name
                });
            }
            return View(model);
        }

        [HttpGet("add")]
        [Authorize(Roles = "admin")]

        public IActionResult Add()
        {
            var categories = _categoryService.GetAll();
            var categoriesViewModel = new List<CategoryViewModel>();
            foreach (var item in categories)
            {
                categoriesViewModel.Add(new CategoryViewModel { Id = item.Id, Name = item.Name });
            }

            var model = new CourseAddViewModel
            {
                Categories = categoriesViewModel,
            };
            return View(model);
        }

        [HttpPost("add")]
        [Authorize(Roles = "admin")]

        public IActionResult Add(CourseAddViewModel model)
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            Course course = new Course
            {
                Description = model.Description,
                Tags = model.Tags,
                IsPopular = model.IsPopular,
                Title = model.Title,
                User = user,
                CategoryId = model.CategoryId
            };
            if (model.FileResource != null)
            {
                course.ImageUrl = UploadFile.Upload(model.FileResource);
            }
            var check = _courseService.Insert(course);
            return Redirect("/course");
        }

        [HttpDelete("delete/{id}")]
        [Authorize(Roles = "admin")]

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var check = _courseService.Delete(new Course { Id = id });

            if (check)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet("edit/{id}")]
        [Authorize(Roles = "admin")]

        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return View();
            }
            var categories = _categoryService.GetAll();
            List<CategoryViewModel> categoryViewModels = new List<CategoryViewModel>();

            foreach (var item in categories)
            {
                categoryViewModels.Add(new CategoryViewModel { Id = item.Id, Name = item.Name });
            }

            var course = _courseService.Get(id);
            CourseEditViewModel model = new CourseEditViewModel
            {
                Id = course.Id,
                Categories = categoryViewModels,
                Tags = course.Tags,
                Title = course.Title,
                CategoryName = course.Category.Name,
                Description = course.Description,
                IsPopular=course.IsPopular
            };


            return View(model);
        }

        [HttpPost("edit")]
        [Authorize(Roles = "admin")]

        public IActionResult Edit(CourseEditViewModel model)
        {
            var oldCourse = _courseService.Get(model.Id);

            oldCourse.IsPopular = model.IsPopular;
            oldCourse.Description = model.Description;
            oldCourse.Tags = model.Tags;
            oldCourse.Title = model.Title;
            oldCourse.CategoryId = model.CategoryId;

            if (model.CategoryId != 0)
            {
                oldCourse.CategoryId = model.CategoryId;
            }
            if (model.FileResource != null)
            {
                oldCourse.ImageUrl = UploadFile.Upload(model.FileResource);
            }
            var check = _courseService.Update(oldCourse);

            if (check)
            {
                return Redirect("/course");
            }
            return Redirect("/course/edit/" + model.Id);
        }

        [HttpGet("search")]
        [AllowAnonymous]

        public IActionResult Search(CourseSearchViewModel model)
        {
            List<CourseViewModel> coursesViewModel = new List<CourseViewModel>();
            List<Course> courses = new List<Course>();
            List<CategoryViewModel> categoriesViewModel = new List<CategoryViewModel>();
            var categories = _categoryService.GetAll();
            foreach (var item in categories)
            {
                categoriesViewModel.Add(new CategoryViewModel { Id = item.Id, Name = item.Name });
            }
            model.Categories = categoriesViewModel;
            if (model.CategoryId != 0)
            {
                var category = categories.FirstOrDefault(x => x.Id == model.CategoryId);
                if (!string.IsNullOrEmpty(model.Tags))
                {
                    courses = category.Courses.Where(x => x.Tags.Contains(model.Tags.Trim())).ToList();
                    coursesViewModel = Mapp(courses);
                    model.Courses = coursesViewModel;
                    return View(model);
                }
                courses = category.Courses.ToList();
                coursesViewModel = Mapp(courses);
                model.Courses = coursesViewModel;
                return View(model);

            }
            else if (!string.IsNullOrEmpty(model.Tags))
            {
                var allCourses = _courseService.GetAll();
                courses = allCourses.Where(x => x.Tags.Contains(model.Tags.Trim())).ToList();
                coursesViewModel = Mapp(courses);
                model.Courses = coursesViewModel;

                return View(model);
            }

            model.Courses = Mapp(_courseService.GetAll());
            return View(model);
        }
        private List<CourseViewModel> Mapp(List<Course> courses)
        {
            List<CourseViewModel> coursesViewModel = new List<CourseViewModel>();
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                var userId = _userManager.GetUserAsync(HttpContext.User).Result.Id;

                foreach (var item in courses)
                {
                    bool subb = false;


                    var sub = _subscriptionService.GetUserSubscriptions(new Subscription { CourseId = item.Id, UserId = userId });
                    if (sub.Count > 0)
                    {
                        subb = true;
                    }

                    coursesViewModel.Add(new CourseViewModel { Subscribed = subb, Category = item.Category.Name, Name = item.Title, Description = item.Description, Duration = item.Length, Id = item.Id, ImageUrl = item.ImageUrl, Tags = item.Tags, VideoCount = item.Lectures.Count });
                }
                return coursesViewModel;
            }
            foreach (var item in courses)
            {
                coursesViewModel.Add(new CourseViewModel { Category = item.Category.Name, Name = item.Title, Description = item.Description, Duration = item.Length, Id = item.Id, ImageUrl = item.ImageUrl, Tags = item.Tags, VideoCount = item.Lectures.Count });
            }
            return coursesViewModel;
        }
    }
}
