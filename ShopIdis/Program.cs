using (Shop shop = new Shop("Grocery Mart", "123 Main Street", ShopType.Grocery))
{
    Console.WriteLine("Shop Information:");
    Console.WriteLine($"Name: {shop.Name}");
    Console.WriteLine($"Address: {shop.Address}");
    Console.WriteLine($"Type: {shop.Type}");
}

Console.WriteLine("Program completed.");