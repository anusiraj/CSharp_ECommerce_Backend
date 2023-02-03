using static System.Console;

namespace Models.CartModel
{
  public class Cart
  {
    public int UserId{get;set;}
    public string[]? ProductNames { get; set; }
    public int ProductPrice { get; set; }
    public string ProductImage { get; set; }
    public int SingleProductQuantity { get; set; }
    public int TotalQuantity { get; set; }
    public int TotalPrice { get; set; }

    public string[] ProductName
    {
      get => ProductNames;
      set
      {
        if (ProductNames.Length == 0) WriteLine("Cart is Empty");
        ProductNames = value;
      }
    }

    public Cart(string[] pname, int pprice, string pimage, int singlePQuantity, int totalQuantity, int totalPrice)
    {
      ProductNames = pname;
      ProductPrice = pprice;
      ProductImage = pimage;
      SingleProductQuantity = singlePQuantity;
      TotalQuantity = totalQuantity;
      TotalPrice = totalPrice;
    }
    public static void GetAllCartItems()
    {

    }
    public static void IncrementQuantity(int pid)
    {

    }
    public static void RemoveProdcut(int pid)
    {

    }
    public static void TotalProducts()
    {

    }
    public static void TotalAmount()
    {

    }
    public override string ToString()
    {
      return "Name" + ProductNames + " " + "Category" + ProductPrice + " " + "Price" + ProductImage + "Description" + SingleProductQuantity + " " +
      " " + "Image" + TotalQuantity + " " + "Image" + TotalPrice;
    }

  }
}