﻿using lab_1.Context;
using lab_1.Domain;
using lab_1.Dtos.RequestDtos;
using lab_1.Dtos.RequestDtos.RequestConverters;
using lab_1.Dtos.ResponseDtos;
using lab_1.Dtos.ResponseDtos.ResponseConverters;
using lab_1.Entities;

using Microsoft.AspNetCore.Mvc;

namespace lab_1.Controllers
{
    [ApiController]
    [Route("api/v1.0/authors")]
    public class AuthorsController:ControllerBase
    {
        private BaseService<AuthorRequestDto,AuthorResponseDto> authorService;
        public AuthorsController(BaseService<AuthorRequestDto,AuthorResponseDto> authorService)
        {
            this.authorService = authorService;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<AuthorResponseDto>> GetAuthors() => Ok(authorService.GetAll());

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<AuthorResponseDto>> CreateAuthor([FromBody] AuthorRequestDto dto)
        {
           return CreatedAtAction("CreateAuthor", await authorService.Create(dto));
        }

        [HttpDelete("{id}")]

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult DeleteAuthor(long id)
        {
            return authorService.Delete(id).Result?NoContent():NotFound(); 
        }

        [HttpPut]
        public ActionResult<AuthorResponseDto> UpdateAuthor([FromBody] AuthorRequestDto dto)
        {

            return authorService.Update(dto) == null ? NotFound(dto) : Ok(dto);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<AuthorResponseDto>> GetAuthor(long id) => Ok(await authorService.Read(id));

    }
}
/*{
"login":"asd",
"password":"asd",
"firstname":"asdf",
"lastname":"sdjkaf"
}*/