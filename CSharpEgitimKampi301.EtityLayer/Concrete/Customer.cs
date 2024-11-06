using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EtityLayer.Concrete
{
    public class Customer
    {
        // Programlamada solidler var.
        // SOLİD 
        // SİNGLE RESPONSİBLTY ==> Tek sorumluluk ilkesi  bir sınıf bir bileşen yada bir interfacce , bağlı bulunduğu alanda tebir işlem yapmalı.
        // Mesela bir medtod tek işi yapmalı mesela: 4 işlmeyapıyor ve kullanıcı isimlerini büyük harfe çevirmemeli. İki iş yapmamalı. 
        // Hem customer bilgisi hemde sipariş bilgisini tutmamalı. bunların ayrı ayrı tutulması lazım mesela. 



        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }     
        public string CustomerDistrict { get; set; }     // müşterinin işlçe bilgisi 
        public string CustomerCity{ get; set; }     // müşterinin şehir bilgisi. 

        public List<Order> Orders  { get; set; }


    }
}
