using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanPage.Models
{
    public class ApplicationDbContext : DbContext
    {
        //db set for each models is used to create a table for each model
        public ApplicationDbContext(
           DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
