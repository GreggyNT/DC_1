using lab_1.Domain;

namespace lab_1.Dtos.ResponseDtos.ResponseConverters
{
    public class StoryResponseConverter : BaseResponse<StoryResponseDto, Story>
    {
        public StoryResponseDto ToDto(Story entity)
        {
            var dto = new StoryResponseDto();
            dto._title = entity.Title;
            dto._created = entity.Created;
            dto._authorId = entity.AuthorId;
            dto._id = entity.Id;
            dto._modified = entity.Modified;
            return dto;
        }
    }
}
