using static System.Console;
using Models.CategoryModel;

namespace Controllers.CategoryController
{
  public class CategoryController
  {
    public CategoryController()
    {

    }
    public void DisplayAllCategories()
    {
      try
      {
        Category.GetAllCategories();
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void DisplayProductsByCategory(int cid)
    {
      try
      {
        Category.GetProductsByCategory(cid);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
  }
}