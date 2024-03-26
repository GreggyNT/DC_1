using lab_1.Dtos.RequestDtos;
using lab_1.Dtos.ResponseDtos;

namespace lab_1.Services
{
    public class CommentService : BaseService<CommentRequestDto, CommentResponseDto>
    {
        public CommentResponseDto Create(CommentRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public long Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<CommentResponseDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public CommentResponseDto? Read(long id)
        {
            throw new NotImplementedException();
        }

        public CommentResponseDto Update(CommentRequestDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
