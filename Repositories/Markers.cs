using lab_1.Domain;

namespace lab_1.Repositories
{
    public class Markers : IRepository
    {
        private Dictionary<long, Marker> _markerDict;
        public Markers() { _markerDict = new(); }

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
