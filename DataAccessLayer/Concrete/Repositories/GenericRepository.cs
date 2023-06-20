using DataAccesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c=new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object=c.Set<T>();
        }

        public void Delete(T p)
        {
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;
           // _object.Remove(p);
            c.SaveChanges();
        }

        public T GET(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);  //sadece bir değer döndürür
        }

        public void Insert(T p)
        {
            var addeEntity = c.Entry(p);
            addeEntity.State = EntityState.Added; //ekleme
           // _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
          return  _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();  //bir den fazla yani bir liste döndürür 
        }

        public void Update(T p)
        {
            var updatedEntity=c.Entry(p);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
