namespace Models;

using static System.Console;

public class Cart
{
  public int? ID { get; init; }
  public List<Product>? Products { get; set; }
  public int? Quantity { get; set; } = 1;
  public int? TotalQuantity { get; set; }
  public int? TotalPrice { get; set; }
  public User User { get; set; }
}