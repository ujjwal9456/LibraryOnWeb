namespace LibraryService.Domain
{
    public interface ILibraryRepository
    {
        Task<Library> Add(Library library);
        Task<Library> Update(Library library);
        Task Delete(Library library);
        Task<Library> Get(int id);
    }
}
