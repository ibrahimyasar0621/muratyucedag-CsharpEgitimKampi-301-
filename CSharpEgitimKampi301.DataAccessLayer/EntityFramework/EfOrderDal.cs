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
    public class EfOrderDal:GenericRepository<Order>,IOrderDal   // genericrepository den miras alıyor Order için. Aynı zamanda IOrderDal'dan miras al.
    {
    }
}
