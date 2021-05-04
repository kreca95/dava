using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Data.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string Url { get; set; }
        /// <summary>
        /// u sekundama
        /// </summary>
        public int Length { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int OrderNum { get; set; }
        public string Tags { get; set; }

    }
}
