using DavidProjekt.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavidProjekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Subscription>().HasKey(c => new { c.UserId, c.CourseId });
            IdentityRole role = new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "admin", NormalizedName = "ADMIN" };
            IdentityRole userRole = new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7211", Name = "user", NormalizedName = "USER" };

            builder.Entity<IdentityRole>().HasData(role);
            builder.Entity<IdentityRole>().HasData(userRole);

            var hasher = new PasswordHasher<User>();

            User user = new User
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                UserName = "admin",
                Email = "admin@admin.ba",
                FirstName = "admin",
                LastName = "admin",
                PasswordHash = hasher.HashPassword(null, "admin"),
                NormalizedEmail = "ADMIN@ADMIN.BA",
                NormalizedUserName = "ADMIN"
            };
            builder.Entity<User>().HasData(user);
            var user2 = new User
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb0", // primary key
                UserName = "user",
                Email = "user@user.ba",
                FirstName = "user",
                LastName = "user",
                PasswordHash = hasher.HashPassword(null, "user"),
                NormalizedEmail = "USER@USER.BA",
                NormalizedUserName = "USER"
            };
            builder.Entity<User>().HasData(user2);

            builder.Entity<IdentityUserRole<string>>().HasData(
               new IdentityUserRole<string>
               {
                   RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                   UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
               }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(

           new IdentityUserRole<string>
           {
               RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
               UserId = "8e445865-a24d-4543-a6c6-9443d048cdb0"
           }
            );
            base.OnModelCreating(builder);
        }
    }
}
