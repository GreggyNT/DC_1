using System.Diagnostics.Eventing.Reader;

namespace lab_1.Domain
{
    public class BaseEntity
    {
        protected long? _id;
        public long? Id { get => _id; }

        public BaseEntity(long? id) 
        {
            _id = id;
        }
    }
}
