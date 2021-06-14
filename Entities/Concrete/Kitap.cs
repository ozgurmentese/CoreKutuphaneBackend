using Core.Entities;

namespace Entities.Concrete
{
    public class Kitap : IEntity
    {
        public int Id { get; set; }
        public string Isbnno { get; set; }
        public string Ad { get; set; }
        public int YazarId { get; set; }
        public int TurId { get; set; }
        public int SayfaSayisi { get; set; }
        public int Puan { get; set; }
    }

}
