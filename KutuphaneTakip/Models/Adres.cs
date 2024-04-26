namespace KutuphaneTakip.Models
{
    public class Adres
    {
        public int AdresId { get; set; }
        public string OgrenciAdres { get; set; }
        public int OgrenciId { get; set; } 
        public Ogrenci Ogrenci { get; set; }
    }
}
