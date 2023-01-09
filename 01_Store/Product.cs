using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Store
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StroId { get; set; }

        //Navigateon Property

        public Store UrununDükkani { get; set; }

    }
}
