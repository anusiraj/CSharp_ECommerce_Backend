using static System.Console;
using Models.ProductModel;

namespace Controllers.ProductController
{
  public class ProductController
  {
    public void DisplayAllProducts()
    {
      try
      {
        Product.GetAllProducts();
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void DisplayProductById(int pid)
    {
      try
      {
        Product.GetProductById(pid);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void DisplayProductByName(string pname)
    {
      try
      {
        Product.GetProductByName(pname);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void SortProductByPrice()
    {
      try
      {
        Product.SortPoductsByPrice();
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void ProductQuantity(int pid)
    {
      try
      {
        Product.IsProductAvailable(pid);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void CreateNewProduct(Product data)
    {
      try
      {
        Product.CreateProduct(data);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void UpdateExistingProduct(int pid)
    {
      try
      {
        Product.UpdateProduct(pid);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void DeleteExistingProduct(int pid)
    {
      try
      {
        Product.DeleteProduct(pid);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
  }
}