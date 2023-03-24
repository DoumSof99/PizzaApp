using RazorPage.Data;
using RazorPage.Models;


// Run this part of code once to create rows in the product table

using PizzaContext context = new PizzaContext();

//Product vegetarianPizza = new Product()
//{
//    Name = "Veggie Pizza",
//    Price = 9.99m
//};
//context.Products.Add(vegetarianPizza);

//Product deluxePizza = new Product()
//{
//    Name = "Deluce Pizza",
//    Price = 13.20m
//};
//context.Products.Add(deluxePizza);

//context.SaveChanges();

//--------------------------------------------
//This part is for updating an entity in the DB

//var vegPizza = context.Products.Where(p => p.Name == "Veggie Pizza").FirstOrDefault();

//if (vegPizza is Product) { vegPizza.Price = 10.99m; }

//context.SaveChanges();

//--------------------------------------------
//This part is for deleting an entity in the DB

//var vegPizza = context.Products.Where(p => p.Name == "Veggie Pizza").FirstOrDefault();

//if (vegPizza is Product) { context.Remove(vegPizza); }

//context.SaveChanges();


var products = from product in context.Products
               where product.Price > 10.00m
               orderby product.Name
               select product;

foreach (Product p in products)
{
    Console.WriteLine($"Id:{p.Id}");
    Console.WriteLine($"Name:{p.Name}");
    Console.WriteLine($"Price:{p.Price}");
    Console.WriteLine(new string('-', 20));
}
