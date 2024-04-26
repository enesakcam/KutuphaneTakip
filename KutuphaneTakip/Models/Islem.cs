namespace KutuphaneTakip.Models
{
    public class Islem
    {
        public int IslemId { get; set; }
        public int OgrenciId { get; set; }
        public int KitapId { get; set; }
        public DateTime AlisTarih { get; set; }
        public DateTime VerisTarih { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public Kitap Kitap { get; set; }
    }
}
