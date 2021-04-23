using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Writer
    {   
        [Key]
        public int WriterID { get; set; }     //YazarId
        [StringLength(50)]
        public string WriterName { get; set; }  //YazarIsim  
        [StringLength(50)]
        public string WriterSurname { get; set; }   //YazarSoyad
        [StringLength(100)]
        public string WriterImage { get; set; }  //YazarResim
        [StringLength(50)]
        public string WriterMail { get; set; }  //YazarMail
        [StringLength(20)]
        public string WriterPassword { get; set; }  //YazarSifre

        //İLİŞKİLER
        public ICollection<Heading> Headings { get; set; }  /*Başlığı hangi yazarın açtığını bulablieceğim. 
                                                             * 1-n ilişki Writer burada 1 kısmında Heading ise n kısmındadır.*/

        public ICollection<Content>  Contents { get; set; }     //Yazar ile içerik ilişkili hale geldi

    }
}
