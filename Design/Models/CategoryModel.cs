using static System.Console;

namespace Models.CategoryModel
{
  public class Category
  {
    public int CId { get; init; }
    public string CName { get; set; }
    public string CImage { get; set; }

    public Category(int cid, string cname, string cimage)
    {
      CId = cid;
      CName = cname;
      CImage = cimage;
    }

    public static void GetAllCategories()
    {
      WriteLine("Returns all Categories");
    }
    public static void GetProductsByCategory(int CId)
    {
      WriteLine("Returns all products inside specific category");
    }
    public override string ToString()
    {
      return "Category ID:" + CId + " " + "Name" + CName + " " + "Image" + CImage + " ";
    }
  }
}