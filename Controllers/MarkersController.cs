using lab_1.Dtos.RequestDtos;
using lab_1.Dtos.ResponseDtos;
using lab_1.Services;
using Microsoft.AspNetCore.Mvc;

namespace lab_1.Controllers
{
    [ApiController]
    [Route("api/v1.0/markers")]
    public class MarkersController : ControllerBase
    {
        MarkerService authorService = new ();
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<MarkerResponseDto>> GetAuthors() => Ok(authorService.GetAll());

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<MarkerResponseDto> CreateAuthor([FromBody] MarkerRequestDto dto) => CreatedAtAction("CreateAuthor", authorService.Create(dto));
        [HttpDelete("{id}")]

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult DeleteAuthor(long id)
        {
            authorService.Delete(id);
            return NoContent();
        }

        [HttpPut]
        public ActionResult<MarkerResponseDto> UpdateAuthor([FromBody] MarkerRequestDto dto) => Ok(authorService.Update(dto));

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<MarkerResponseDto> GetAuthor(long id) => Ok(authorService.Read(id));

    }
}
