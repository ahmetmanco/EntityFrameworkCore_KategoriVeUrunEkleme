using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_UrunEklemeOtomasyonu.Entities
{
    internal class Category : BaseEntitiy
    {
        [MaxLength(255)]//eğer max uzunluk verilmezse nvarchar(max) 255 olarak ayarlansın
        public string Description { get; set; }

        public List<Product> Products { get; set;}

    }
}
