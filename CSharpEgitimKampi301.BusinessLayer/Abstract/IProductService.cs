using CSharpEgitimKampi301.EtityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product> //IGnericService den product için miras al dedik. 
    {
    }
}
