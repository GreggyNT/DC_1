using lab_1.Domain;

namespace lab_1.Repositories
{
    public class Authors : IRepository
    {
        private Dictionary<long, Author> _authorDict;

        public Authors() { _authorDict = new (); }
        public void AddValue(BaseEntity value)
        {
            throw new NotImplementedException();
        }

        public void DeleteValue(long id)
        {
            throw new NotImplementedException();
        }

        public BaseEntity FindById(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateValue(long id)
        {
            throw new NotImplementedException();
        }
    }
}
