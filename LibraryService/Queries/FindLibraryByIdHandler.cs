using LibraryService.Api.Queries;
using LibraryService.Api.Queries.Dtos;
using MediatR;

namespace LibraryService.Queries
{
    public class FindLibraryByIdHandler : IRequestHandler<FindLibraryByIDQuery, LibraryDto>
    {
        
        public Task<LibraryDto> Handle(FindLibraryByIDQuery request, CancellationToken cancellationToken)
        {


            throw new NotImplementedException();
        }
    }
}
