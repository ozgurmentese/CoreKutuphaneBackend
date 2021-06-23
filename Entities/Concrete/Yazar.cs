using Core.Entities;

namespace Entities.Concrete
{
    public class Yazar : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
