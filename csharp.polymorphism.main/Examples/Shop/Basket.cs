using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.polymorphism.main.Examples.Shop.Interfaces;

namespace csharp.polymorphism.main.Examples.Shop
{
    public class Basket
    {
        private List<IProduct> _products = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public List<IProduct> GetProducts { get { return _products; } }

        public decimal BasketTotal { get { return _products.Sum(x => x.Price); } }

        public void DeleteProduct(int id)
        {
            _products.RemoveAll(x => x.Id == id);
        }
    }
}
