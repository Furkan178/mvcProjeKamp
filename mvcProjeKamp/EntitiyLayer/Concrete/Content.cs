using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Content
    {   
        [Key]
        public int ContentID { get; set; }     //IcerikID
        [StringLength(1000)]
        public string ContentValue { get; set; }      //IcerikDeger  
        public DateTime ContentDate { get; set; }   //IcerikTarih

        //İLİŞKİLER
        public int HeadingID { get; set; }              //başlık ile içerik ilişkili hale geldi
        public virtual Heading Heading { get; set; }    //başlık ile içerik ilişkili hale geldi

        public int? WriterID { get; set; }         //Yazar ile içerik ilişkili hale geldi
        public virtual Writer Writer { get; set; }      //Yazar ile içerik ilişkili hale geldi

    }
}
