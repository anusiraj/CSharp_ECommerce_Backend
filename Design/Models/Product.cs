namespace Models;

using static System.Console;

public class Product
{
  public int ID { get; init; }
  public string Name { get; set; }
  public string Category { get; set; }
  public int Price { get; set; }
  public string Descritption { get; set; }
  public string[] Images { get; set; }

  public Product(int id, string name, string category, int price, string description, string[] images)
  {
    ID = id;
    Name = name;
    Category = category;
    Price = price;
    Descritption = description;
    Images = images;
  }

  public override string ToString()
  {
    return "Product ID:" + ID + " " + "Name" + Name + " " + "Category" + Category + " " + "Price" + Price + "Description" + Descritption + " " +
    " " + "Image" + Images[0] + " ";
  }
}