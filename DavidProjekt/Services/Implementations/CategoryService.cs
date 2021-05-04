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
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Delete(Category data)
        {
            _context.Categories.Remove(data);
            return _context.SaveChanges() > 0;
        }
        public Category Get(int id)
        {
            return _context.Categories.Include(x => x.Courses).ThenInclude(x => x.Lectures).FirstOrDefault(x => x.Id == id);
        }

        public List<Category> GetAll()
        {
            return _context.Categories.Include(x => x.Courses).ThenInclude(x => x.Lectures).ToList();
        }

        public bool Insert(Category data)
        {
            _context.Categories.Add(data);
            return _context.SaveChanges() > 0;
        }

        public bool InsertRange(List<Category> data)
        {
            _context.Categories.AddRange(data);
            return _context.SaveChanges() > 0;
        }

        public bool Update(Category data)
        {
            _context.Categories.Update(data);
            return _context.SaveChanges() > 0;

        }

        public bool UpdateRange(List<Category> data)
        {
            _context.Categories.UpdateRange(data);
            return _context.SaveChanges() > 0;
        }
    }
}
