using lab_1.Domain;
using lab_1.Dtos.RequestDtos;
using lab_1.Dtos.RequestDtos.RequestConverters;
using lab_1.Dtos.ResponseDtos;
using lab_1.Dtos.ResponseDtos.ResponseConverters;
using lab_1.Repositories;

namespace lab_1.Services
{
    public class MarkerService : BaseService<MarkerRequestDto, MarkerResponseDto>
    {
        Repository<Marker> comments;
        MarkerRequestConverter commentRequest;
        MarkerResponseConverter commentResponse;
        ListMarkerResponseConverter converter;
        public MarkerService()
        {
            comments = new Repository<Marker>();
            commentRequest = new MarkerRequestConverter();
            commentResponse = new MarkerResponseConverter();
            converter = new ListMarkerResponseConverter();
        }
        public MarkerResponseDto Create(MarkerRequestDto dto)
        {
            comments.AddValue(commentRequest.FromDto(dto, comments.NextId));
            return commentResponse.ToDto(comments.FindById(comments.NextId - 1));
        }

        public void Delete(long id)
        {
            comments.DeleteValue(id);
        }

        public MarkerResponseDto? Read(long id) => commentResponse.ToDto(comments.FindById(id));


        public MarkerResponseDto Update(MarkerRequestDto dto)
        {
            comments.UpdateValue(commentRequest.FromDto(dto, dto.id), dto.id);
            return commentResponse.ToDto(comments.FindById(dto.id));
        }

        public List<MarkerResponseDto> GetAll() => converter.MarkersResponse(comments.GetAuthors()).ToList();
    }
}
