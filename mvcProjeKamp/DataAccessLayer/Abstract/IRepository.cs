using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{   //Burası ICategoryDal daki yöntemi kullanmak yerine asıl kullanacağımız yöntemdir.
    /* Bu yapıya örneğin öncekinde ki gibi Category' i vermemem gerekiyor.Onun yerine dışarıdan gelecek olan
     * Entitiy'i(Tabloyu) göndermem gerekiyor.
     */

    /* Bu yapı genericlic yapısıdır.*/
    public interface IRepository<T> //Bu T değeri benim türüm(Type) olacak.Tablo göndereceğim için.Örneğin About gönderdik onu karşılayacak.
    {
        //CRUD methodlar ise CategoryDal dakilerin aynısı tek fark olarak T'yi alacaklar.

        List<T> List();
        void Insert(T p);  //Yine fark olarak göndereceğimiz tablodan(T'den) parametre almış oluyoruz.

        void Delete(T p);

        void Update(T p);

        List<T> List(Expression<Func<T,bool>>filter); //Bu listeleme methodu ise şartlı listelemedir.
    }
}
