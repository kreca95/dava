using DavidProjekt.Data;
using DavidProjekt.Data.Models;
using DavidProjekt.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly ApplicationDbContext _context;

        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Delete(Course data)
        {
            _context.Courses.Remove(data);
            return _context.SaveChanges() > 0;
        }

        public Course Get(int id)
        {
            return _context.Courses.Include(x => x.Lectures).FirstOrDefault(x => x.Id == id);
        }

        public List<Course> GetAll()
        {
            return _context.Courses.Include(x => x.Lectures).Include(x => x.Category).ToList();
        }

        public bool Insert(Course data)
        {
            _context.Courses.Add(data);
            return _context.SaveChanges() > 0;
        }

        public bool InsertRange(List<Course> data)
        {
            _context.Courses.AddRange(data);
            return _context.SaveChanges() > 0;
        }

        public bool Update(Course data)
        {
            _context.Courses.Update(data);
            return _context.SaveChanges() > 0;
        }

        public bool UpdateRange(List<Course> data)
        {
            _context.Courses.UpdateRange(data);
            return _context.SaveChanges() > 0;
        }
    }
}
