using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{   //Bu ICategoryDal örnek olması açısından kalacak.
    public interface ICategoryDal:IRepository<Category>
    {
        //CRUD operasyonlarını birer method olarak tanımlayacağım
        //Type Name(); şeklinde method tanımlayacağız.

        //List<Category> List(); // Türü List olan ismi List olan bir method tanımladık. Aynı olmak zorunda değil ing. olsun diye böyle yaptık.

        //void Insert(Category p); 

        //void Update(Category p);

        //void Delete(Category p);

        // Ekleme,Güncelleme,Silme işlemlerini yapmak için Category sınıfından gelen bir p parametresine ihtiyaç duyarız.
        //CRUD operasyonlarının gerçekleşeceği birer method tanımladım.
        //Bunları tanımladıktan sonra, bir tane class oluşturmam gerekiyor ve bu class'ta ise buradaki methodların görevlerini yazmam gerekiyor.
    }
}
