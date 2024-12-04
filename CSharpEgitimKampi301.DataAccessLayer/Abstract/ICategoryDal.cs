using CSharpEgitimKampi301.EtityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    // Sen IGenericDal dan miras alacaksın dedik. Bu mirası category sınıfıı için miras al dedik. Böylece listeleme silme gibi işlemleri yapmaya hazır hale getirdik. 
    {
        void Update(Product entity);
    }
}
