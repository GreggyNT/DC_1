using lab_1.Domain;
using lab_1.Entities;

namespace lab_1.Dtos.RequestDtos.RequestConverters
{
    public class AuthorRequestConverter:BaseRequest<TblAuthor,AuthorRequestDto>
    {
        public TblAuthor FromDto (AuthorRequestDto dto,long id)=>new TblAuthor(id,dto?.login,dto?.password,dto?.firstname,dto?.lastname);
    }
}
