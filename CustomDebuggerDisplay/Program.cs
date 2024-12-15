using CustomDebuggerDisplay;

var order = new Order
{
    Customer = new Customer
    {
        Email = "john.smith@gmail.com",
        Name = "John Smith"
    },
    OrderId = MartianIdGenerator.Next(),
    OrderItems =
     [
         new OrderItem {
             Product = new Product
             {
                 Name = "Laptop",
                 Description = "Dell laptop",
                 Price = 1499.99m,
             },
             ProductId = MartianIdGenerator.Next(),
             Quantity = 10
         },
         new OrderItem {
             Product = new Product
             {
                 Name = "Phone",
                 Description = "iPhone 13",
                 Price = 1099.99m
             },
             ProductId = MartianIdGenerator.Next(),
             Quantity = 7
         }
     ],
    ShippingAddress = new ShippingAddress
    {
        City = "New York",
        Country = "United States of America",
        PostalCode = "12345",
        State = "New York",
        Street = "Main St"
    }
};

Console.WriteLine(order);
