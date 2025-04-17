using Microsoft.EntityFrameworkCore;
using JwtAuthProject.Models;
using System.Collections.Generic;

namespace JwtAuthProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}