using lab_1.Domain;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using System.Diagnostics.Eventing.Reader;

namespace lab_1.Repositories
{
    public class Repository<T>
    {
        private Dictionary<long, T> _Dict;

        public long NextId { get => _Dict.Count + 1; }
        public Repository() { _Dict = new(); }
        public void AddValue(T value)
        {
            _Dict.Add(NextId, value);
        }

        public void DeleteValue(long id)
        {
            _Dict.Remove(id);
        }

        public T FindById(long id)
        {
            return _Dict[id - 1];
        }

        public void UpdateValue(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAuthors() => _Dict.Values;

    }
}
