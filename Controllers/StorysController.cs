using lab_1.Dtos.RequestDtos;
using lab_1.Dtos.ResponseDtos;
using lab_1.Services;
using Microsoft.AspNetCore.Mvc;

namespace lab_1.Controllers
{
    [ApiController]
    [Route("api/v1.0/storys")]
    public class StorysController : ControllerBase
    {
        StoryService authorService = new StoryService();
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<StoryResponseDto>> GetAuthors() => Ok(authorService.GetAll());

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<StoryResponseDto> CreateAuthor([FromBody] StoryRequestDto dto) => CreatedAtAction("CreateAuthor", authorService.Create(dto));
        [HttpDelete("{id}")]

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult DeleteAuthor(long id)
        {
            authorService.Delete(id);
            return NoContent();
        }

        [HttpPut]
        public ActionResult<StoryResponseDto> UpdateAuthor([FromBody] StoryRequestDto dto) => Ok(authorService.Update(dto));

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<StoryResponseDto> GetAuthor(long id) => Ok(authorService.Read(id));

    }
}
