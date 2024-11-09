using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class  // Sen dışarıdan bir T değeri alacaksın. Bir şart yazdım bu T değeri mutlaka class olmalı dedik.
    {

        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
        

    }
}
