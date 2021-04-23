using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{   //Aslında bu kullanım yanlıştır. Bu ICategoryDal örnek olması açısından kalacak. 
    //Şu yüzden yanlış; Örneğin büyük bir projede 100 tane tablom olduğunu düşünürsek 
    //100 tablo içinde bu işlemleri tek tek yapmak değiştirmek gibi bir imkan kurumsal mimariye ters bir yapıdadır.
    //Zaten mantık olarak bakarsak yazılımcıyı çok fazla yoracak ve uzun sürecek bir yapıdır. O yüzden bu kullanım tavsiye edilmemektedir.
    public class CategoryRepository : ICategoryDal   //Burası gibi bütün sınıflarımıza aynı işlemi yapmaktansa daha generic bir yapı kullanacağız.
    {   //ICategoryDal üzeirne gelip implement interface dediğimiz zaman burada methodlarımız oluşuyor.
        //Yani interface'dan kalıtım yapmak için methodlarını kullanmak zorunda olduğumu bildiriyor.

        Context c = new Context();
        DbSet<Category> _object;  //DbSet türünde bir nesneye ihtiyacımız olduğu için _object nesnesini tanımladık.
        //_object Category sınıfının değerlerini tutar.
        
        public void Delete(Category p)
        {
            _object.Remove(p);  //Parametreden gelen değeri _object içerisinde bulunan sınıfımdan sildim.
            c.SaveChanges();    //Context'te değişiklikleri kaydet demektir. Bu ifadenin klasik ADO.Net'te ki karşılığı ExecuteNonQuery()'dir. 
        }

        public void Insert(Category p)
        {
            _object.Add(p);     //Parametreden gelen değeri _object içerisinde bulunan sınıfıma ekledim.
            c.SaveChanges();    //Context'te değişiklikleri kaydet demektir. Bu ifadenin klasik ADO.Net'te ki karşılığı ExecuteNonQuery()'dir. 
        }

        public List<Category> List()
        {

            return _object.ToList();    //ToList methodu EntityFrameWork'te verileri listelemek için kullanılan bir methoddur. 
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();   //Güncelleme işleminde direk değişiklikleri kaydedeceğim.
        }

        /*
         * ToList----> Listelemek için 
         * Add------>Ekleme işlemleri için
         * Remove----->Silme işlemleri için
         * Find---->Bulma işlemleri için
         */
    }
}
