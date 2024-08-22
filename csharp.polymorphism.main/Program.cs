using csharp.polymorphism.main.Examples.Shop;
using csharp.polymorphism.main.Examples.Shop.Interfaces;
using workshop.console.Examples.Shop;

Basket basket = new Basket();

IProduct product1 = new Guitar() { Id=1,   Name="Gibson SG", Price=1299.95M, Discount=15, NumberOfStrings=6 };
IProduct product2 = new Guitar() { Id = 2, Name = "Fender Stratocaster", Price = 1299.95M, Discount = 10, NumberOfStrings=6 };
IProduct product3 = new Guitar() { Id = 3, Name = "Fender D12 Dreadnought", Price = 1299.95M, Discount = 10, NumberOfStrings=12};
IProduct product4 = new Drums() { Id = 4,  Name = "Pearl Export", Price = 1100.99M };
IProduct product5 = new Drums() { Id = 5,  Name = "Pearl Export 2.0", Price = 1100.99M };

basket.AddProduct(product1);
basket.AddProduct(product2);
basket.AddProduct(product3);
basket.AddProduct(product4);
basket.AddProduct(product5);

foreach(IProduct item in basket.Products)
{

    Console.WriteLine($"{item.Name} is a {item.GetType()}");
    
    if (item is IDiscountable)
    {
        Console.WriteLine($"implements IDiscountable: Discount={(item as IDiscountable).Discount}");

    }
    if (item is IStringable)
    {
        
        Console.WriteLine($"implements IStringable: NumberOfStrings={(item as IStringable).NumberOfStrings}");
        
        //Console.WriteLine(((IStringable)item).NumberOfStrings); //casting is a bit more old school

    }
    Console.WriteLine(new string('*', 10));
}


Console.WriteLine(new string('-', 10));
Console.WriteLine("Just IDiscountable");

foreach (IDiscountable item in basket.Products.Where(x => x is IDiscountable))
{

    Console.WriteLine($"{(item as IProduct).Name} has a Discount of {item.Discount}");
}