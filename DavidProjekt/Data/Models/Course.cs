using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Data.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        /// <summary>
        /// Minute length
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// odvojit 
        /// </summary>
        public string Tags { get; set; }
        public string ImageUrl { get; set; }
        public bool IsPopular { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Lecture> Lectures { get; set; }

    }
}
