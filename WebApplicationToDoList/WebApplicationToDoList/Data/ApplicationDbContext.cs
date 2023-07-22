using Microsoft.EntityFrameworkCore;
using WebApplicationToDoList.Models;

namespace WebApplicationToDoList.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        
        }

        public DbSet<Todoo> todoo { get; set; }
    }
}
