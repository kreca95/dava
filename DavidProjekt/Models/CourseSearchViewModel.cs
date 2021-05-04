using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Models
{
    public class CourseSearchViewModel
    {
        public int CategoryId { get; set; }
        public string Tags { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
        public List<CourseViewModel> Courses { get; set; }

    }
}
