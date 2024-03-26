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
        public Task<ActionResult<AuthorResponseDto>>
    }
}
