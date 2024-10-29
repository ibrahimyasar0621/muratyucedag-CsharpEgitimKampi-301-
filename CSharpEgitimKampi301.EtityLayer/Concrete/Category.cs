using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EtityLayer.Concrete
{
    public class Category
    {
        // 1. KISIM
        // Bu oluşturduğumuz sınıf ctegory sınıfı. Oluşturacağımız yada oluşacak olan  kategori tablosuna ait değerleri tutacak. 
        // Daha önce normalde SQL de tabloyu ooluşturup C# a çekiyorduk.    TABLO--->QUERY query bazlı çekiyorduk.
        // Şimdi ise bir CLASS oluşturacağız bu clas SQL'd bir tabloya dönüşecek.    CLASS--->TABLE
        // Bu tablonun  içinde PROPERTY'ler olacak bunlarda ilgilii tablonun SÜTÜNlarına dönüşecek.   PROPERTY--->COULUMN
        // Bu yaklaşıma CODEFİRST YAKLAŞIMI DİYORUZ. 

        // 2. KISIM 
        // Yukarıda internal(biz public yaptık) class yazıyor bu bir ACCESS MODİFİERS (ERİŞİM BELİRLEYİCİ)
        // Genelde biz PUBLİC(HERYERDEN ERİŞİLECEKSE) -- PRİVİTE (TEK YERDEN ERİŞİLECEKSE) -- INTERNAL -- PROTECT  4 temel en çok kullandığımız erşim belirtecimiz var.
        // Erişim belirleyici bizim belirlediğimiz bir interface yada sınıfın yada başkabir öge bir metodun mesela, kimler tarafından erişilebileceğinin belirlendiği bir kısıtlama aracııdır aslında. 
        // INTERNAL sadece bulunduğu katmandan erişim sağlamaya izin veriyor. Mesela bizimkinde sağda solution explorerdaki sadece  enntity katmanından erişiliyor.
        // biz public yapıcaz her yerden erişim olsun diye.

        // FİELD-VARİABLE-PROPERTY
        // eğer bir değişken direkt sınıfın(class) içinne tanımlanırsa bu bir FİELD oluyor. int x; ----> field
        // Eğerki değişken sonuna get; ve set; alırsa bu bir property oluyor. public int y { get; set; } 
        // Eğerki bir değğişken metod içinde tanımlanıyorsa VARİABLE. void test() { int z; }

        // Kategoori tablomuzun sütünlarını oluşturalım.
        // CODEFİRST yaklaşımında eğer buradaki değeri veritabanına yollayacaksak kodumuzu PROPERTY olarak yazmalıyız. 
        // prop yazınca çıkyor zaten

        public int CategoryId { get; set; }  // ÇOK ÖNEMLİ=> Kategori adı yazarken ismi birebir aynı yazılmalı sonuna Id eklemelisin. Bu yazım şekli otomatik artan ve birincil anahtar olduğunu anlar. categoryId yazarsan anlamaz. 
        public string CategoryName { get; set; } // get ve set aslında CtegoryName adındaki değerimi istediğim formatta kullanmam için  olanak tanıyor.

        public bool CategoryStatus { get; set; }



    }
}
