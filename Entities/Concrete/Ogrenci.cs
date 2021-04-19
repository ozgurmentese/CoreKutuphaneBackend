using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Ogrenci : IEntity
    {
        public int Numarasi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Sinif { get; set; }
    }
}
