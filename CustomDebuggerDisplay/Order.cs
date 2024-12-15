using System.Diagnostics;
using System.Globalization;

namespace CustomDebuggerDisplay;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public class Order
{
    public required string OrderId { get; set; }
    public required Customer Customer { get; set; }
    public required List<OrderItem> OrderItems { get; set; }
    public required ShippingAddress ShippingAddress { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string DebuggerDisplay => $"{OrderId} - {Customer.Name} - {OrderItems.Count} order items ({OrderItems.Sum(o => o.Quantity)} products in total)";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public class Customer
{
    public required string Name { get; set; }
    public required string Email { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string DebuggerDisplay => $"{Name} ({Email})";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public class OrderItem
{
    public required string ProductId { get; set; }
    public required Product Product { get; set; }
    public int Quantity { get; set; } = 1;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string DebuggerDisplay => $"{Product.Name} x {Quantity} @ {Product.Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public class Product
{
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public required string Description { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string DebuggerDisplay => $"{Name} ({Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))})";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public class ShippingAddress
{
    public required string Street { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public required string PostalCode { get; set; }
    public required string Country { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string DebuggerDisplay => $"{Street}, {City}, {State}, {PostalCode}, {Country}";
}
