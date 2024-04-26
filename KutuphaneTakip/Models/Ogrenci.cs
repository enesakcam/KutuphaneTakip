namespace KutuphaneTakip.Models
{
    public class Ogrenci
    {

        public int OgrenciId { get; set; }
        public int OgrenciNo { get; set; }
        public string OgrenciAdSoyad { get; set; }
        public string OgrenciSinif { get; set; }
        public Adres Adres { get; set; }
        public ICollection<Islem> Islem { get; set; }
    }
}   
