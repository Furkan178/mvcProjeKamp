using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{   //Bu yapı bütün bileşenlerin tamamını kapsayacak.
    public class GenericRepository<T> : IRepository<T> where T : class //Göndereceğim T değeri bir class olsun şartı koştum.
    {
        Context c = new Context();
        DbSet<T> _object;

        //Ben burada T değerine karşılık gelecek olan sınıfı bulmam için constructor yazacağım.

        public GenericRepository()
        {
            _object = c.Set<T>();  //Object nesnesine Contexte bağlı olarak gönderilen T değeri olacak.    
        }

        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();    //Filter'dan gelen değere göre bana listeleme yap.
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
