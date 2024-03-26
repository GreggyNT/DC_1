using lab_1.Domain;

namespace lab_1.Dtos.ResponseDtos.ResponseConverters
{
    public class AuthorResponseConverter
    {
        public AuthorResponseDto ToDto(Author author) 
        {
            AuthorResponseDto res = new AuthorResponseDto();
            res._firstname = author.Firstname;
            res._lastname = author.Lastname;
            res._id = author.Id;
            res._password = author.Password; 
            return res;
        }
    }
}
