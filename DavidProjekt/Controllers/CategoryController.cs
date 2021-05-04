using DavidProjekt.Data.Models;
using DavidProjekt.Helpers;
using DavidProjekt.Models;
using DavidProjekt.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Controllers
{
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {

            var categories = _categoryService.GetAll();
            var model = new List<CategoryViewModel>();
            foreach (var item in categories)
            {
                model.Add(new CategoryViewModel { Id = item.Id, Description = item.Description, Name = item.Name, ImageUrl = item.ImageUrl });
            }
            return View(model);

        }
        [HttpGet("add")]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost("add")]
        public IActionResult Add(CategoryAddViewModel model)
        {
            var category = new Category
            {
                Description = model.Description,
                ImageUrl = UploadFile.Upload(model.FileResource),
                Name = model.Name,
                IsPopular = model.IsPopular
            };
            var check = _categoryService.Insert(category);
            if (check)
            {
                return Redirect("/category");
            }
            return View();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            bool check = false;
            if (id != 0)
            {
                check = _categoryService.Delete(new Category { Id = id });
                if (check)
                {
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            if (id != 0)
            {
                var category = _categoryService.Get(id);
                var model = new CategoryEditViewModel
                {
                    Id = category.Id,
                    Description = category.Description,
                    ImageUrl = category.ImageUrl,
                    IsPopular = category.IsPopular,
                    Name = category.Name
                };
                return View(model);
            }
            return View();
        }
        [HttpPost("edit")]
        public IActionResult Edit(CategoryEditViewModel model)
        {
            if (model == null)
            {
                return View(model);
            }
            Category category = new Category();
            category.Description = model.Description;
            category.IsPopular = model.IsPopular;
            category.Name = model.Name;
            category.Id = model.Id;
            if (model.FileResource != null)
            {
                category.ImageUrl = UploadFile.Upload(model.FileResource);
            }

            var check = _categoryService.Update(category);
            if (check)
            {
                return Redirect("/category");
            }
            return Ok();
        }
    }
}
