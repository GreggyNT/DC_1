using lab_1.Dtos.RequestDtos;
using lab_1.Dtos.ResponseDtos;

namespace lab_1.Services
{
    public class MarkerService : BaseService<MarkerRequestDto, MarkerResponseDto>
    {
        public MarkerResponseDto Create(MarkerRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public long Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<MarkerResponseDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public MarkerResponseDto? Read(long id)
        {
            throw new NotImplementedException();
        }

        public MarkerResponseDto Update(MarkerRequestDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
