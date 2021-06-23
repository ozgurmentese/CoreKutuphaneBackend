using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class KutuphaneKitap:IDto
    {
        public int IslemNo { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public string Sinif { get; set; }
        public string KitapAdı { get; set; }
        public DateTime AlisTarih { get; set; }
        public DateTime? VerisTarih { get; set; }
        public int ToplamGun { get; set; }
    }
}
