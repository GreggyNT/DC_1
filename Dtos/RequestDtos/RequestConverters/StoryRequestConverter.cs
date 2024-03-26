using lab_1.Domain;

namespace lab_1.Dtos.RequestDtos.RequestConverters
{
    public class StoryRequestConverter : BaseRequest<Story, StoryRequestDto>
    {
        public Story FromDto(StoryRequestDto dto, long? id)
        {
            return new Story(id, dto._authorId, dto._title, dto._content, dto._created, dto._modified);
        }
    }
}
