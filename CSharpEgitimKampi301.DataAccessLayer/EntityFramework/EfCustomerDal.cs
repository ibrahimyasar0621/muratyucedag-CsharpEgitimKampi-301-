using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EtityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public  class EfCustomerDal:GenericRepository<Customer>, ICustomerDal  // genericrepository den miras alıyor Customer için. Aynı zamanda ICustomerDal'dan miras al.
    {
    }
}
