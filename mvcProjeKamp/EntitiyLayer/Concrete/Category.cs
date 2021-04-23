using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Category
    {   
        [Key]
        public int CategoryID { get; set; }  //KategoriID
        [StringLength(50)]
        public string CategoryName { get; set; } //KategoriIsim
        [StringLength(200)]
        public string CategoryDescription { get; set; }    //KategoriAciklama
        public bool CategoryStatus { get; set; }   //KategoriDurum
           
        //İLİŞKİLER
        public ICollection<Heading> Headings { get; set; }  /* heading ile kategori tablosunu ilişkilendirdik.*/
    }
}
