namespace Entities.DTOs
{
    public class KitapAdYazarTurGetirDto
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string TurAdi { get; set; }
        public int YazarId { get; set; }
        public int TurId { get; set; }
    }
}