using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Models
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VideoCount { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }

    }
}
