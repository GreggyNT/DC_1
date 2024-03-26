﻿using lab_1.Domain;

namespace lab_1.Dtos.ResponseDtos.ResponseConverters
{
    public class AuthorResponseConverter
    {
        public AuthorResponseDto ToDto(Author author) 
        {
            AuthorResponseDto res = new AuthorResponseDto();
            res.firstname = author.Firstname;
            res.login = author.Login;
            res.lastname = author.Lastname;
            res._id = author.Id;
            res.password = author.Password; 
            return res;
        }
    }
}
