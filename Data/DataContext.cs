using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kida_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Kida_1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Students");
        }
    }
}
