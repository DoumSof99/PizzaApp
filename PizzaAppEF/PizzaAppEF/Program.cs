using RazorPage.Data;
using RazorPage.Models;

using PizzaContext context = new PizzaContext();

#region This part of code create rows in the Product table
Product vegetarianPizza = new Product()
{
    Name = "Veggie Pizza",
    Price = 9.99m
};
context.Products.Add(vegetarianPizza);

Product deluxePizza = new Product()
{
    Name = "Deluce Pizza",
    Price = 13.20m
};
context.Products.Add(deluxePizza);

//context.SaveChanges();
#endregion
//--------------------------------------------
#region This part of code create rows in the Customer table
Customer customer1 = new Customer()
{
    FirstName = "Sofia", 
    LastName = "Doumani",
    Address = "Somewhere 9",
    Phone = "6912345678",
    Email = "Sof@gmail.com"
};
context.Customers.Add(customer1);

Customer customer2 = new Customer()
{
    FirstName = "Patrick",
    LastName = "Hunt",
    Address = "Microsoft 10",
    Phone = "6987654321",
    Email = "Patrick@gmail.com"
};
context.Customers.Add(customer2);

//context.SaveChanges();

#endregion
//--------------------------------------------
#region This part is for updating an entity in the DB

var vegPizza1 = context.Products.Where(p => p.Name == "Veggie Pizza").FirstOrDefault();

if (vegPizza1 is Product) { vegPizza1.Price = 10.99m; }

//context.SaveChanges();
#endregion
//--------------------------------------------
#region This part is for removing an entity in the DB

var vegPizza2 = context.Products.Where(p => p.Name == "Veggie Pizza").FirstOrDefault();

if (vegPizza2 is Product) { context.Remove(vegPizza2); }

//context.SaveChanges();
#endregion

#region This part id for displaying the above data with some statements
var products = from product in context.Products
               where product.Price > 10.00m
               orderby product.Name
               select product;

foreach (Product p in products)
{
    //Console.WriteLine($"Id:{p.Id}");
    //Console.WriteLine($"Name:{p.Name}");
    //Console.WriteLine($"Price:{p.Price}");
    //Console.WriteLine(new string('-', 20));
}
#endregion
