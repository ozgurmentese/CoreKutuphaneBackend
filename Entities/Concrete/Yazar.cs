using Core.Entities;

namespace Entities.Concrete
{
    public class Yazar : IEntity
    {
        public int YazarNumarasi { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }

    }

}
