using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{   //Burada tanımlayacağım property ler Sql de tablo ismi olarak karşılık bulacak.
    //Bunun içi DataAccessLayer içerisine Entity Framework paketini kurmamız gerekiyor.
    public class Context: DbContext  // Kalııtım yaptık.
    {   
        //EntityLayer içerisindeki bütün sınıfları Property olarak ekliyoruz.

        public DbSet<About> Abouts { get; set; }   //About projemin içerisinde yer alan sınıf ismi.
                                                   //Abouts ise bizim sql'de veritabanında Tablo ismine yanısyacak isim
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }


        //Context kısmı buraya yazılmış olan DbSet şeklindeki property'leri Sql'e birer tablo olarak yansıtacak.
    }
}
