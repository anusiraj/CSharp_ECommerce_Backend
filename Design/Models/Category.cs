namespace Models;

public class Category
{
  public int ID { get; init; }
  public string Name { get; set; }
  public string Image { get; set; }

  public Category(int id, string name, string image)
  {
    ID = id;
    Name = name;
    Image = image;
  }

  public override string ToString()
  {
        return "Category ID:" + ID + " " + "Name" + Name + " " + "Image" + Image + " ";
  }
}