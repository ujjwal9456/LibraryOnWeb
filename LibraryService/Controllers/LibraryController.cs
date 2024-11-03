using LibraryService.Api.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryService.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LibraryController(IMediator mediator)
        {
                _mediator = mediator;
        }


        [HttpGet("{Id}")]
        public async Task<ActionResult> GetByCode([FromRoute] int Id)
        {
            var result = await _mediator.Send(new FindLibraryByIDQuery { Id = Id});
            return new JsonResult(result);
        }


    }
}
