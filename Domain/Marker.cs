namespace lab_1.Domain
{
    public class Marker:BaseEntity
    {
        private string _name;

        public Marker(long id, string name):base(id) => _name = name;

        public string Name { get => _name; } 
    }
}
