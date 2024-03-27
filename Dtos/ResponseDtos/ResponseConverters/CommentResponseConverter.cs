using lab_1.Domain;

namespace lab_1.Dtos.ResponseDtos.ResponseConverters
{
    public class CommentResponseConverter : BaseResponse<CommentResponseDto, Comment>
    {
        public CommentResponseDto ToDto(Comment entity)
        {
            CommentResponseDto dto = new CommentResponseDto();
            dto._content = entity.Content;
            dto._id = entity.Id;
            dto._storyId = entity.StoryId;
            return dto;
        }
    }
}
