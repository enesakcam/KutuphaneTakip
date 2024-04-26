namespace KutuphaneTakip.Models
{
    public class KitapTur
    {
        public int KitapTurId { get; set; }
        public string KitapTurAdi { get; set; }
        public ICollection<Kitap> Kitap { get; set; }
    }
}
