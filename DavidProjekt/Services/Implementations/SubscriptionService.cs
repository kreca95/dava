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
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ApplicationDbContext _context;

        public SubscriptionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Delete(Subscription data)
        {
            _context.Subscriptions.Remove(data);
            return _context.SaveChanges() > 0;
        }

        public Subscription Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Subscription> GetAll()
        {
            return _context.Subscriptions.ToList();
        }

        public List<Subscription> GetUserSubscriptions(Subscription subscription)
        {
            if (!string.IsNullOrEmpty(subscription.UserId) && subscription.CourseId != 0)
            {
                return _context.Subscriptions
                    .Where(x => x.UserId == subscription.UserId && x.CourseId == subscription.CourseId)
                    .Include(x => x.Course)
                    .Include(x => x.User)
                    .ToList();
            }
            if (string.IsNullOrEmpty(subscription.UserId) && subscription.CourseId != 0)
            {
                return _context.Subscriptions
                        .Where(x => x.CourseId == subscription.CourseId)
                        .Include(x => x.Course)
                        .Include(x => x.User)
                        .ToList();
            }
            if (!string.IsNullOrEmpty(subscription.UserId) && subscription.CourseId == 0)
            {
                return _context.Subscriptions
                        .Where(x => x.UserId == subscription.UserId)
                        .Include(x => x.Course)
                        .Include(x => x.User)
                        .ToList();
            }
            return null;
        }

        public bool Insert(Subscription data)
        {
            _context.Subscriptions.Add(data);
            return _context.SaveChanges() > 0;
        }

        public bool InsertRange(List<Subscription> data)
        {
            _context.Subscriptions.AddRange(data);
            return _context.SaveChanges() > 0;
        }

        public bool Update(Subscription data)
        {
            _context.Subscriptions.Update(data);
            return _context.SaveChanges() > 0;
        }

        public bool UpdateRange(List<Subscription> data)
        {
            _context.Subscriptions.UpdateRange(data);
            return _context.SaveChanges() > 0;
        }
    }
}
