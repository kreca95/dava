using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Models
{
    public class CourseEditViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]

        public string Title { get; set; }
        public string Image { get; set; }
        [Required]

        public string Tags { get; set; }
        [Required]

        public int CategoryId { get; set; }
        [Required]

        public List<CategoryViewModel> Categories { get; set; }
        public IFormFile FileResource { get; set; }
        [Required]

        public string CategoryName { get; set; }
        [Required]

        public string Description { get; set; }
        public bool IsPopular { get; set; }

    }
}
