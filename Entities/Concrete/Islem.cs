using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Islem : IEntity
    {
        public int Id { get; set; }
        public int OgrenciNumarasi { get; set; }
        public int KitapNumarasi { get; set; }
        public DateTime AlinanTarih { get; set; }
        public DateTime VerilenTarih { get; set; }
    }

}
