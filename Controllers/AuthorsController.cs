using lab_1.Domain;
using lab_1.Dtos.RequestDtos;
using lab_1.Dtos.ResponseDtos;
using lab_1.Services;
using Microsoft.AspNetCore.Mvc;

namespace lab_1.Controllers
{
    [ApiController]
    [Route("api/v1.0/authors")]
    public class AuthorsController:ControllerBase
    {
        AuthorService authorService = new AuthorService();
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<AuthorResponseDto>> GetAuthors() => Ok(authorService.GetAll());

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<AuthorResponseDto> CreateAuthor([FromBody]AuthorRequestDto dto) => CreatedAtAction("CreateAuthor", authorService.Create(dto));
        [HttpDelete("{id}")]

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult DeleteAuthor(long id)
        {
            authorService.Delete(id);
            return NoContent(); 
        }

        [HttpPut]
        public ActionResult<AuthorResponseDto> UpdateAuthor([FromBody] AuthorRequestDto dto) => Ok(authorService.Update(dto));

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<AuthorResponseDto> GetAuthor(long id) => Ok(authorService.Read(id));

    }
}
/*{
"login":"asd",
"password":"asd",
"firstname":"asdf",
"lastname":"sdjkaf"
}*/