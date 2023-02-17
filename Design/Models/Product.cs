namespace Models;

public class Product
{
  public int ID { get; init; }
  public string Name { get; set; }
  public int CategoryID { get; set; }
  public int Price { get; set; }
  public string Descritption { get; set; }
  public string[] Images { get; set; }

  public Product(int id, string name, int categoryId, int price, string description, string[] images)
  {
    ID = id;
    Name = name;
    CategoryID = categoryId;
    Price = price;
    Descritption = description;
    Images = images;
  }

  public override string ToString()
  {
        return "Product ID:" + ID + " " + "Name" + Name + " " + "Category" + CategoryID + " " + "Price" + Price + "Description" + Descritption + " " +
        " " + "Image" + Images[0] + " ";
  }
}