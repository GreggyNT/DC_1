using lab_1.Domain;

namespace lab_1.Dtos.RequestDtos.RequestConverters
{
    public class AuthorRequestConverter:BaseRequest<Author,AuthorRequestDto>
    {
        public  Author FromDto (AuthorRequestDto dto,long id)=>new Author(dto._id==null?id:dto._id,dto?._login,dto?._password,dto?._firstname,dto?._lastname);
    }
}
