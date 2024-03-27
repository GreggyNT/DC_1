using lab_1.Dtos.RequestDtos;
using lab_1.Dtos.ResponseDtos;
using lab_1.Services;
using Microsoft.AspNetCore.Mvc;

namespace lab_1.Controllers
{
    [ApiController]
    [Route("api/v1.0/comments")]
    public class CommentsController : ControllerBase
    {
        CommentService authorService = new();
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<CommentResponseDto>> GetAuthors() => Ok(authorService.GetAll());

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<CommentResponseDto> CreateAuthor([FromBody] CommentRequestDto dto) => CreatedAtAction("CreateAuthor", authorService.Create(dto));
        [HttpDelete("{id}")]

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult DeleteAuthor(long id)
        {
            authorService.Delete(id);
            return NoContent();
        }

        [HttpPut]
        public ActionResult<CommentResponseDto> UpdateAuthor([FromBody] CommentRequestDto dto) => Ok(authorService.Update(dto));

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<CommentResponseDto> GetAuthor(long id) => Ok(authorService.Read(id));

    }
}
