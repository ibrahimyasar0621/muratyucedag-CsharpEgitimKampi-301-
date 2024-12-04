using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EtityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;    // sen IcategoryDal dan _categoryDal isminde field örnekleyeceksin dedik. bu bir fiel çünkü class ın içinde direky tanımlandı.
                                                       // eğer metodun içinde tanımlansaydı bu sefer değişken olacaktı. field olmayacaktı.
                                                       // Sonunda get ve set olsaydı propery olacaktı.
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
            // BURAYI CATEGORY DAL YAZISINA CTRL+. BASIP CONSTRACTOR METHOD DİYİP GEİTDİK. BU YAPININ GENEL ADI DA BU.BU ASLINDA DEPENDENSE İNJECTİON UYGULUYOR.
        }

        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TInsert(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
        // BURADA DATACCES DEKİ METODLARIMIZI ÇAĞIRDIK.  BUSİNESS KATMANINDAKİ METODLARIMIN İÇİNE.
    }
}
