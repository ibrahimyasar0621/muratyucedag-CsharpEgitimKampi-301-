﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EtityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }      // productId miz olsun 
        public string ProductName { get; set; }    // Bir ürünün ismi olsun. isim olduuğu için string kullandık. 
        public int ProductStock { get; set; }   // Stoğum olsun kaç adet olduğunu göreyim
        public decimal ProductPrice { get; set; }   // Productun bir pricesi satış fiyatıolsun. decimal yaptık cünkü ondalıklı türde fiyatımız olursa diye.
        public string ProductDescription { get; set; }   // Productun bir açıklaması olsun.
        public int CategoryId { get; set; }             // Her bir ürünün bir kategorisi olmalı 
        public virtual Category Category { get; set; }  // Ktegori tablosuun değerlerine ürün üzerinden ulaşmak için 
        public List<Order> Orders { get; set; }

        //[NotMapped]
        //public string CategoryName { get; set; }

    }
}
