namespace lab_1.Domain
{
    public class Author:BaseEntity
    {
        private string _login;
        private string _password;
        private string _firstname;
        private string _lastname;

        public Author(long id, string login, string password, string firstname, string lastname) : base(id)
        {  
                _login = login;
                _password = password;
                _firstname = firstname;
                _lastname = lastname;
        }

        public string Login { get => _login; }
        public string Password { get => _password;}
        public string Firstname { get => _firstname;}
        public string Lastname { get => _lastname;}

    }
}
