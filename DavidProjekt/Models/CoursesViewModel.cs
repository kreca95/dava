using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Models
{
    public class CoursesViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string User { get; set; }
        public TimeSpan Duration { get; set; }
        public string Tags { get; set; }
        public string ImageUrl { get; set; }
        public bool IsPopular { get; set; }
        public bool IsSubbed { get; set; }


    }
}
