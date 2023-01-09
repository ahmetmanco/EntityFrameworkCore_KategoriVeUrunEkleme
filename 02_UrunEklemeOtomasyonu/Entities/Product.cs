using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_UrunEklemeOtomasyonu.Entities
{
    internal class Product : BaseEntitiy
    {

        public decimal? UnitPrice { get; set; }
        public short Stock { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        //Navigation property
        public Category Category { get; set; }
    }
}
