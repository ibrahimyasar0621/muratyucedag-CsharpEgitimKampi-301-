using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EtityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;  // Eğer başında _ alttire koymassam generate contructor dediğimde başına this anahtarı atamaya başlıyor. bu sefer her şeyi this ile çağırmam lazım . bunu yapmamak için başına _ koyuyorum.

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }
        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }
        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }
        public void TInsert(Customer entity)
        {
            if (entity.CustomerName != "" && entity.CustomerName.Length >= 3 && entity.CustomerCity != null && entity.CustomerSurname != "" && entity.CustomerName.Length<=30)  
                // İF eğer entitden gelen değer boşluktan farklı ise yani içinde bir değer varsa,VE, customer name in uzunluğu büyük eşit 3 ise , VE ,customercitsy değeri null dan farklı ise ,VE , entityden gelen customersurname boşluktan farklı ise, VE ,entityden gelen customername'nin lengti 30dan küçük
                // Bunu böyle karmaşık yazmak yerine daha clean code daha profesyonel yazılması için farklı bir kütüphane lazım.
            {
                // EKLEME işlemi yap. 
                _customerDal.Insert(entity);
            }
            else
            {
                // Hata mesajı ver.
                
            }
        }
        public void TUpdate(Customer entity)
        {
            if (entity.CustomerId != 0 && entity.CustomerCity.Length >= 3) // entityden gelen customerid değeri 0dan farklı ise ,VE, entityden gelen şehir uzunluğu 3 hare eşit yada büyükse bu işlemi yap. yoksa haa mesajı ver dedik. ama hata mesajını girmedik şimdilik boş geçtik.
            {
                _customerDal.Update(entity);
            }
            else
            {
                // hata mesajı ver. 
            }
            
        }

        // Dataaccess katmanının aynısını yazdık ama buradaki en önemli fark burada validasyon şartlarını yazıyoruz. biz burada sadece öernek olması için insert'e yazdık ama diğerleri içinde yazılır.
        // örne olması için update kısmınıda doldurduk.
    }
}
