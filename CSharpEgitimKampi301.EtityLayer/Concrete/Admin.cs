using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EtityLayer.Concrete
{
    public class Admin
    {
        [Key]   // bu birincil anahtar olarak atama yapıyor. 
        public int admin {  get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
