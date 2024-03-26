using lab_1.Domain;
using lab_1.Dtos.RequestDtos;
using lab_1.Dtos.RequestDtos.RequestConverters;
using lab_1.Dtos.ResponseDtos;
using lab_1.Dtos.ResponseDtos.ResponseConverters;
using lab_1.Repositories;

namespace lab_1.Services
{
    public class AuthorService : BaseService<AuthorRequestDto, AuthorResponseDto>
    {
        Repository<Author> authors = new();
        AuthorRequestConverter authorRequest;
        AuthorResponseConverter authorResponse;
        ListAuthorResponseConverter converter = new ListAuthorResponseConverter();

        public AuthorResponseDto Create(AuthorRequestDto dto)
        {
           authors.AddValue(authorRequest.FromDto(dto, authors.NextId));
           return authorResponse.ToDto(authors.FindById(authors.NextId-2));
        }

        public long Delete(long id)
        {
            throw new NotImplementedException();
        }

        public AuthorResponseDto? Read(long id)
        {
            throw new NotImplementedException();
        }

        public AuthorResponseDto Update(AuthorRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public List<AuthorResponseDto> GetAll() => converter.AuthorsResponse(authors.GetAuthors()).ToList();
    }
}
