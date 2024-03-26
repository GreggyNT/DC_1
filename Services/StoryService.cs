using lab_1.Dtos.RequestDtos;
using lab_1.Dtos.ResponseDtos;
using lab_1.Repositories;

namespace lab_1.Services
{
    public class StoryService : BaseService<StoryRequestDto, StoryResponseDto>
    {
        private Stories _stories;
        
        public StoryService() => _stories = new Stories();

        public Stories Stories { get => _stories; }

        public StoryResponseDto Create(StoryRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public long Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<StoryResponseDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public StoryResponseDto? Read(long id)
        {
            throw new NotImplementedException();
        }

        public StoryResponseDto Update(StoryRequestDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
