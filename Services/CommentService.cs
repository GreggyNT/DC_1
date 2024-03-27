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
        ListCommentResponseConverter converter;
        public CommentService()
        {
            comments = new Repository<Comment>();
            commentRequest = new CommentRequestConverter();
            commentResponse = new CommentResponseConverter();
            converter = new ListCommentResponseConverter();
        }
        public CommentResponseDto Create(CommentRequestDto dto)
        {
            comments.AddValue(commentRequest.FromDto(dto, comments.NextId));
            return commentResponse.ToDto(comments.FindById(comments.NextId - 1));
        }

        public void Delete(long id)
        {
            comments.DeleteValue(id);
        }

        public CommentResponseDto? Read(long id) => commentResponse.ToDto(comments.FindById(id));


        public CommentResponseDto Update(CommentRequestDto dto)
        {
            comments.UpdateValue(commentRequest.FromDto(dto, dto.id), dto.id);
            return commentResponse.ToDto(comments.FindById(dto.id));
        }

        public List<CommentResponseDto> GetAll() => converter.CommentsResponse(comments.GetAuthors()).ToList();
    }
}
