using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Heading
    {   
        //prop yazıp iki defa tab tuşuna basıldığında property verecektir.
        
        [Key]
        public int HeadingID { get; set; }     //BaslikID

        [StringLength(50)]
        public string HeadingName { get; set; } //BaslikAdi
        public DateTime HeadingDate { get; set; } //BaslikTarih
            
        //İLİŞKİLER
        public int CategoryID { get; set; }             /* heading ile kategori tablosunu ilişkilendirdik.*/
        public virtual Category Category { get; set; }      /* heading ile kategori tablosunu ilişkilendirdik.*/

        public ICollection<Content> Contents { get; set; }      //başlık ile içerik ilişkili hale geldi

        public int WriterID { get; set; }           /*Başlığı hangi yazarın açtığını bulablieceğim. 
                                                             * 1-n ilişki Writer burada 1 kısmında Heading ise n kısmındadır.*/
        public virtual Writer Writer{ get; set; }   /*Başlığı hangi yazarın açtığını bulablieceğim. 
                                                             * 1-n ilişki Writer burada 1 kısmında Heading ise n kısmındadır.*/
    }
}
