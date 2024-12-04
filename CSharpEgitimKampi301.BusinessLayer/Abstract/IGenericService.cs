using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T entity);   // HEPSİNİN BAŞINA T HARFİ EKLİYORUM ÇÜNKÜ DATAACSES KATMANINDAKİ METODLARIMIZ İLE BUSINESS KATMANI İÇİNDEKİ METODLARIMIZ KARIŞMASIN.--> TInsert
        void TUpdate(T entity);   // HEPSİNİN BAŞINA T HARFİ EKLİYORUM ÇÜNKÜ DATAACSES KATMANINDAKİ METODLARIMIZ İLE BUSINESS KATMANI İÇİNDEKİ METODLARIMIZ KARIŞMASIN.--> TUpdate
        void TDelete(T entity);  // HEPSİNİN BAŞINA T HARFİ EKLİYORUM ÇÜNKÜ DATAACSES KATMANINDAKİ METODLARIMIZ İLE BUSINESS KATMANI İÇİNDEKİ METODLARIMIZ KARIŞMASIN.--> TDelete
        List<T> TGetAll();
        T TGetById(int id);   // böylece biz presentationda çağırırken  yazarken T harfini metodların başına yazacağız ve DATA ACCESS direkt erişmek yerine arada bir köprü görevi görevi görenn katman üzerinden erişim sağlamış olacağız.
    }
}
