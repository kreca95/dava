using DavidProjekt.Data.Models;
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
    [Authorize]
    public class SubscriptionController : Controller
    {
        private readonly ISubscriptionService _subscriptionService;
        private readonly UserManager<User> _userManager;

        public SubscriptionController(ISubscriptionService subscriptionService, UserManager<User> userManager)
        {
            _subscriptionService = subscriptionService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserAsync(HttpContext.User).Result.Id;
            var sub = _subscriptionService.GetUserSubscriptions(new Subscription { UserId = userId });
            return View();
        }

        [HttpGet("{courseid}")]
        public IActionResult Subscribe(int courseid)
        {
            try
            {
                var userId = _userManager.GetUserAsync(HttpContext.User).Result.Id;
                var sub = new Subscription { UserId = userId, CourseId = courseid };
                var check = _subscriptionService.Insert(sub);
                if (check)
                {
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
    }
}
