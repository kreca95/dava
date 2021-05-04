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
    public class LectureService : ILectureService
    {
        private readonly ApplicationDbContext _context;

        public LectureService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Delete(Lecture data)
        {
            _context.Lectures.Remove(data);
            return _context.SaveChanges() > 0;
        }

        public Lecture Get(int id)
        {
            return _context.Lectures.Find(id);
        }

        public List<Lecture> GetAll()
        {
            return _context.Lectures.Include(x => x.Course).OrderBy(x => x.OrderNum).ToList();
        }

        public List<Lecture> GetLecturesByCourse(int courseId)
        {
            var filtered = GetAll().Where(x => x.CourseId == courseId).ToList();
            return filtered;
        }

        public bool Insert(Lecture data)
        {
            var lectues = GetAll();

            if (!lectues.Any())
            {
                data.OrderNum = 1;
            }
            else
            {
                var max = lectues.Last().OrderNum;
                max += 1;
                data.OrderNum = max;
            }

            _context.Lectures.Add(data);
            return _context.SaveChanges() > 0;

        }

        public bool InsertRange(List<Lecture> data)
        {
            _context.Lectures.AddRange(data);
            return _context.SaveChanges() > 0;

        }

        public bool Update(Lecture data)
        {
            _context.Lectures.Update(data);
            return _context.SaveChanges() > 0;

        }

        public bool UpdateRange(List<Lecture> data)
        {
            foreach (var item in data)
            {
                var lecture = Get(item.Id);
                lecture.OrderNum = item.OrderNum;
                Update(lecture);
            }
            return _context.SaveChanges() > 0;

        }
    }
}
