using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Models
{
    public class LectureAddViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]

        public string Tags { get; set; }
        [Required]

        public IFormFile FileResource { get; set; }
        [Required]
        public int CourseId { get; set; }
        public string Url { get; set; }
        [Required]

        public int OrderNum { get; set; }
    }
}
