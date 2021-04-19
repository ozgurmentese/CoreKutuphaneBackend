using Core.Entities;

namespace Entities.Concrete
{
    public class Kitap : IEntity
    {
        public int KitapNumarasi { get; set; }
        public string Isbnno { get; set; }
        public string KitapAdi { get; set; }
        public int YazarNumarasi { get; set; }
        public int TurNumarasi { get; set; }
        public int SayfaSayisi { get; set; }
        public int Puan { get; set; }
    }

}
