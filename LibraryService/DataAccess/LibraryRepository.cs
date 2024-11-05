using LibraryService.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryService.DataAccess
{
    public class LibraryRepository : ILibraryRepository
    {
        private readonly LibraryDbContext _libraryDbContext;

        public LibraryRepository(LibraryDbContext libraryDbContext)
        {
                _libraryDbContext = libraryDbContext?? throw new ArgumentNullException();
        }
        public Task<Library> Add(Library library)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Library library)
        {
            throw new NotImplementedException();
        }

        public async Task<Library> Get(int id)
        {

            var library = await _libraryDbContext
                .Libraries
                .FirstOrDefaultAsync(p => p.Id == id);
            return library ?? throw new Exception("Library not found with this Id"+ id);
        }

        public Task<Library> Update(Library library)
        {
            throw new NotImplementedException();
        }
    }
}
