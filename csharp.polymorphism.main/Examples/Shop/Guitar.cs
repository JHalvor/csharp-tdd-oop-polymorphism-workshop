using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.polymorphism.main.Examples.Shop.Interfaces;

namespace csharp.polymorphism.main.Examples.Shop
{
    public class Guitar : IProduct, IDiscountable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
        public int Discount { get; set; }
    }
}
