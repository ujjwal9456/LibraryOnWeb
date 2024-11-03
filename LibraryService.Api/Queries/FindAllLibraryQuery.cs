using LibraryService.Api.Queries.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Api.Queries
{
    public class FindAllLibraryQuery : IRequest<IEnumerable<LibraryDto>>
    {

    }
}
