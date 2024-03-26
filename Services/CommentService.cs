using lab_1.Domain;
using lab_1.Dtos.RequestDtos;
using lab_1.Dtos.RequestDtos.RequestConverters;
using lab_1.Dtos.ResponseDtos;
using lab_1.Dtos.ResponseDtos.ResponseConverters;
using lab_1.Repositories;
using System.Xml.Linq;

namespace lab_1.Services
{
    public class CommentService : BaseService<CommentRequestDto, CommentResponseDto>
    {

        Repository<Comment> comments;
        CommentRequestConverter commentRequest;
        CommentResponseConverter commentResponse;
        ListAuthorResponseConverter converter;
        public CommentService()
        {
            comments = new Repository<Comment>();
            commentRequest = new CommentRequestConverter();
            commentResponse = new CommentResponseConverter();
            converter = new ListAuthorResponseConverter();
        }
        public AuthorResponseDto Create(AuthorRequestDto dto)
        {
            authors.AddValue(authorRequest.FromDto(dto, authors.NextId));
            return authorResponse.ToDto(authors.FindById(authors.NextId - 1));
        }

        public void Delete(long id)
        {
            authors.DeleteValue(id);
        }

        public AuthorResponseDto? Read(long id) => authorResponse.ToDto(authors.FindById(id));


        public AuthorResponseDto Update(AuthorRequestDto dto)
        {
            authors.UpdateValue(authorRequest.FromDto(dto, dto.id), dto.id);
            return authorResponse.ToDto(authors.FindById(dto.id));
        }

        public List<AuthorResponseDto> GetAll() => converter.AuthorsResponse(authors.GetAuthors()).ToList();
    }
}
