using lab_1.Domain;
using lab_1.Entities;
using Microsoft.Extensions.FileProviders;

namespace lab_1.Dtos.ResponseDtos.ResponseConverters
{
    public class AuthorResponseConverter:BaseResponse<AuthorResponseDto,TblAuthor>
    {
        public AuthorResponseDto? ToDto(TblAuthor author) 
        {
            AuthorResponseDto? res = new AuthorResponseDto();
            res.id = author.Id;
            res.login = author.Login;
            res.lastname = author.Lastname;
            res.id = author.Id;
            res.firstname = author.Firstname;
            res.password = author.Password; 
            return res;
        }
    }
}
