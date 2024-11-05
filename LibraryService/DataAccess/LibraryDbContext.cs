using LibraryService.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryService.DataAccess
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
                
        }

        public DbSet<Library> Libraries { get; set; }





    }
}
