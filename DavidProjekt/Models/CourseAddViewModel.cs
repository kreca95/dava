using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Models
{
    public class CourseAddViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]

        public string Tags { get; set; }
        public bool IsPopular { get; set; }
        [Required]
        public List<CategoryViewModel> Categories { get; set; }
        [Required]
        public IFormFile FileResource { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }


    }
}
