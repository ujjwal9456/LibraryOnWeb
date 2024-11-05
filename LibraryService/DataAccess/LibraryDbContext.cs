using LibraryService.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryService.DataAccess
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
        {
                
        }

        public DbSet<Library> Libraries { get; set; }





    }
}
