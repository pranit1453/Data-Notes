using Microsoft.EntityFrameworkCore;
using Mini_E_Commerce_Web_API.Models;

namespace Mini_E_Commerce_Web_API.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Users> users {  get; set; }
        public DbSet<Products> products { get; set; }
        public ApplicationDbContext(DbContextOptions options):base(options) 
        {
        }
    }
}
