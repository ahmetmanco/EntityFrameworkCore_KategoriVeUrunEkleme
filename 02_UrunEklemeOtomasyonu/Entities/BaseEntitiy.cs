using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_UrunEklemeOtomasyonu.Entities
{
    internal abstract class BaseEntitiy
    {
        [Key] //bu kolonu primary key olarak ayarla
        [Column(Order =1)]//bütün tablolarda 1. sırada gelsin
        public int Id { get; set; }
        [Required]// Bu alan zorunlu bir alan olarak tanımlansın
        [Column(Order =2)]
        public string Name { get; set; }
        public bool IsActive { get; set; }

        [Column(TypeName ="datetime2")] // kolonun veri tipi datetime2 olarak ayarlansın
        public DateTime AddedDate { get; set; }
    }
}
