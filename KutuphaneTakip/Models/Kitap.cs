using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KutuphaneTakip.Models
{
    public class Kitap
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public string KitapYazar { get; set; }
        public int KitapTurId { get; set; }
        public string YayinEvi { get; set; }
        public KitapTur KitapTur { get; set; }
        public ICollection<Islem> Islem { get; set; }
    }  
       
}   
