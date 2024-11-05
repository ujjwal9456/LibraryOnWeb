using LibraryService.Api.Queries;
using LibraryService.Api.Queries.Dtos;
using LibraryService.DataAccess;
using LibraryService.Domain;
using MediatR;

namespace LibraryService.Queries
{
    public class FindLibraryByIdHandler : IRequestHandler<FindLibraryByIDQuery, LibraryDto>
    {
        private ILibraryRepository _libraryRepository;
        public FindLibraryByIdHandler(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        public async Task<LibraryDto> Handle(FindLibraryByIDQuery request, CancellationToken cancellationToken)
        {

            var result = await _libraryRepository.Get(request.Id);

            var returnValue = new LibraryDto {
                Id = result.Id,
                Name = result.Name,
                Description = result.Description,
                Address = result.Address
            };


            return returnValue ?? throw new Exception("Library not found with id - "+request.Id);
        }
    }
}
