using LibraryService.Api.Queries.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Api.Queries
{
    public class FindLibraryByIDQuery() : IRequest<LibraryDto>
    {
        public int Id { get; set; }
        
    }
}
