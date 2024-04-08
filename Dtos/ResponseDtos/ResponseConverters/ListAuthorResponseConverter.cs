
using lab_1.Entities;

namespace lab_1.Dtos.ResponseDtos.ResponseConverters
{
    public class ListAuthorResponseConverter
    {
        private AuthorResponseConverter authorResponseConverter = new AuthorResponseConverter();
        public IEnumerable<AuthorResponseDto?> AuthorsResponse(IEnumerable<TblAuthor> list) {
            foreach (TblAuthor node  in list) 
                yield return authorResponseConverter.ToDto(node);
            }
    }
}
