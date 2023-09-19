using csharp.polymorphism.main.Examples.Shop;
using csharp.polymorphism.main.Examples.Shop.Interfaces;
using workshop.console.Examples.Shop;

Basket basket = new Basket();

Guitar guitar1 = new Guitar() { Id=1, Name="Gibson SG", Price=1299.95M, Discount=15 };
Guitar guitar2 = new Guitar() { Id = 2, Name = "Fender Stratocaster", Price = 1299.95M, Discount = 10 };
Drums drums1 = new Drums() { Id = 3, Name = "Pearl Export", Price = 1100.99M };
Drums drums2 = new Drums() { Id = 4, Name = "Pearl Export 2.0", Price = 1100.99M };

basket.AddProduct(guitar1);
basket.AddProduct(drums1);
basket.AddProduct(guitar2);
basket.AddProduct(drums2);


foreach(IDiscountable item in basket.GetProducts.Where(x => x is IDiscountable))
{

    Console.WriteLine(item.Discount);
}