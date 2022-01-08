using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ToDoAPIDbContext : DbContext
    {
        public ToDoAPIDbContext()
        {
        }

        public ToDoAPIDbContext(DbContextOptions<ToDoAPIDbContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
            Database.Migrate();
        }
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<Board> Boards { get; set; }
    }
}
