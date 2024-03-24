using lab_1.Domain;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using System.Diagnostics.Eventing.Reader;

namespace lab_1.Repositories
{
    public interface IRepository
    {
        public BaseEntity FindById(long id);
        public void AddValue(BaseEntity value);

        public void UpdateValue(long id);

        public void DeleteValue(long id);

    }
}
