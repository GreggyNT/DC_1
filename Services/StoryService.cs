using lab_1.Domain;
using lab_1.Dtos.RequestDtos;
using lab_1.Dtos.RequestDtos.RequestConverters;
using lab_1.Dtos.ResponseDtos;
using lab_1.Dtos.ResponseDtos.ResponseConverters;
using lab_1.Repositories;

namespace lab_1.Services
{
    public class StoryService : BaseService<StoryRequestDto, StoryResponseDto>
    {
        Repository<Story> comments;
        StoryRequestConverter commentRequest;
        StoryResponseConverter commentResponse;
        ListStoryResponseConverter converter;
        public StoryService()
        {
            comments = new Repository<Story>();
            commentRequest = new StoryRequestConverter();
            commentResponse = new StoryResponseConverter();
            converter = new ListStoryResponseConverter();
        }
        public StoryResponseDto Create(StoryRequestDto dto)
        {
            comments.AddValue(commentRequest.FromDto(dto, comments.NextId));
            return commentResponse.ToDto(comments.FindById(comments.NextId - 1));
        }

        public void Delete(long id)
        {
            comments.DeleteValue(id);
        }

        public StoryResponseDto? Read(long id) => commentResponse.ToDto(comments.FindById(id));


        public StoryResponseDto Update(StoryRequestDto dto)
        {
            comments.UpdateValue(commentRequest.FromDto(dto, dto.id), dto.id);
            return commentResponse.ToDto(comments.FindById(dto.id));
        }

        public List<StoryResponseDto> GetAll() => converter.StorysResponse(comments.GetAuthors()).ToList();
    }
}
