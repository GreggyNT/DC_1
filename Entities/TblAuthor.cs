using System;
using System.Collections.Generic;

namespace lab_1.Entities;

public partial class TblAuthor
{

    public TblAuthor(long id, string login, string password, string firstname, string lastname)
    {
        Id = id;
        Login = login;
        Password = password;
        Firstname = firstname;
        Lastname = lastname;
    }

    public long Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

}
