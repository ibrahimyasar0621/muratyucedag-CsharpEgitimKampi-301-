using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        KampContext context = new KampContext();
        private readonly DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(T entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;  // silme işlemmi entityden gelen değere göre yapılacak.
            context.SaveChanges();
        }

        public List<T> GetAll()     // NORMAL ŞARTLARDA GET ALL BÜTÜN VERİYİ GETİRECEK BANA.
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);  // id den gelen değere göre bul ve getir diyoruz.
        }

        public void Insert(T entity)
        {
            var addedEntity = context.Entry(entity); // Burada eklenecek entity yi hafızaya çektik.
            addedEntity.State = EntityState.Modified;  // Ekleme işlemini gerçekleştirdi.
            context.SaveChanges();  // değişikllikleri kayıt ettik. 
        }

        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity); // Normalde update şilmei için tek tek atama yapıyorduk.
            updatedEntity.State = EntityState.Modified;  // entitystate komutlarındaki modify sayesinde tek tek atama işlemi yapmak zorunda kalmıyoruz.
            context.SaveChanges();
        }
    }
}
