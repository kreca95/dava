using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Data.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CourseId { get; set; }
        public User User { get; set; }
        public Course Course { get; set; }

    }
}
