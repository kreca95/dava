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
using System.Security.Policy;
using System.Threading.Tasks;
using System.Xml;

namespace DavidProjekt.Controllers
{
    [Route("[controller]")]
    [Authorize(Roles = "admin")]

    public class LectureController : Controller
    {
        private readonly ILectureService _lectureService;
        private readonly ICategoryService _categoryService;
        private readonly ISubscriptionService _subscriptionService;
        private readonly UserManager<User> _userManager;

        public LectureController(ILectureService lectureService, UserManager<User> userManager, ICategoryService categoryService, ISubscriptionService subscriptionService)
        {
            _lectureService = lectureService;
            _userManager = userManager;
            _categoryService = categoryService;
            _subscriptionService = subscriptionService;
        }
        [HttpGet("{courseId}")]
        public IActionResult Index(int courseId)
        {
            var courses = _lectureService.GetLecturesByCourse(courseId);
            var model = new List<LectureViewModel>();

            foreach (var item in courses)
            {
                bool subbed = false;
                var userid = _userManager.GetUserAsync(HttpContext.User).Result.Id;
                var sub = _subscriptionService.GetUserSubscriptions(new Subscription { UserId = userid, CourseId = item.CourseId });
                if (sub != null)
                {
                    subbed = true;
                }
                model.Add(new LectureViewModel { Id = item.Id, CourseId = item.CourseId, CourseName = item.Course.Title, Title = item.Title, ImageUrl = item.ImageUrl, OrderNum = item.OrderNum, Length = item.Length, Description = item.Description, Url = item.Url });
            }

            return View(model);
        }
        [HttpGet("add/{courseId}")]
        public IActionResult Add(int courseId)
        {
            var model = new LectureAddViewModel
            {
                CourseId = courseId,
            };
            return View(model);
        }
        [HttpPost("add")]
        public IActionResult Add(LectureAddViewModel model)
        {

            var length = GetYouTubeInfo.GetVideoInfo(model.Url).items[0].contentDetails.duration;
            var duration = XmlConvert.ToTimeSpan(length).TotalSeconds;

            var lecture = new Lecture
            {
                CourseId = model.CourseId,
                Description = model.Description,
                Title = model.Title,
                Url = model.Url,
                Length = Convert.ToInt32(duration)
            };
            if (model.FileResource != null)
            {
                lecture.ImageUrl = UploadFile.Upload(model.FileResource);
            }
            var check = _lectureService.Insert(lecture);
            if (check)
            {
                return Redirect("/lecture/" + model.CourseId);
            }
            return View();
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var lecture = _lectureService.Get(id);
            //ako nisi admin gleda je li tvoj video
            //if (!HttpContext.User.IsInRole("admin"))
            //{
            //    var user = _userManager.GetUserAsync(HttpContext.User).Result;
            //    if (user.Id != lecture.Course.User.Id)
            //    {
            //        return Forbid();
            //    }
            //}

            LectureEditViewModel model = new LectureEditViewModel
            {
                Id = lecture.Id,
                Description = lecture.Description,
                Tags = lecture.Tags,
                Title = lecture.Title,
                Url = lecture.Url,
                CourseId = lecture.CourseId,

            };

            return View(model);
        }

        [HttpPost("edit")]
        public IActionResult Edit(LectureEditViewModel model)
        {
            //ako nisi admin gleda je li tvoj video
            //if (!HttpContext.User.IsInRole("admin"))
            //{
            //    var user = _userManager.GetUserAsync(HttpContext.User).Result;
            //    if (user.Id != lecture.Course.User.Id)
            //    {
            //        return Forbid();
            //    }
            //}
            var oldLecture = _lectureService.Get(model.Id);
            oldLecture.Description = model.Description;
            oldLecture.Tags = model.Tags;
            oldLecture.Title = model.Title;
            oldLecture.Url = model.Url;

            if (model.FileResource != null)
            {
                oldLecture.ImageUrl = UploadFile.Upload(model.FileResource);
            }
            var length = GetYouTubeInfo.GetVideoInfo(model.Url).items[0].contentDetails.duration;
            var duration = XmlConvert.ToTimeSpan(length).TotalSeconds;

            oldLecture.Length = Convert.ToInt32(duration);
            var check = _lectureService.Update(oldLecture);
            if (check)
            {
                return Redirect("/lecture/" + oldLecture.CourseId);
            }
            return View(model);
        }

        [HttpPost("order")]
        public IActionResult Order(List<LectureViewModel> models)
        {
            List<Lecture> lectures = new List<Lecture>();
            foreach (var item in models)
            {
                lectures.Add(new Lecture { Id = item.Id, OrderNum = item.OrderNum });
            }
            _lectureService.UpdateRange(lectures);
            return Redirect("/lecture/" + models.FirstOrDefault().CourseId);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var check=_lectureService.Delete(new Lecture { Id = id });
            if (check)
            {
                return Ok();
            }
            return BadRequest();
        }

    }
}
