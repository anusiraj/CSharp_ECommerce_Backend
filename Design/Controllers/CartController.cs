using static System.Console;
using Models.CartModel;

namespace Controllers.CartController
{
  public class CartController
  {
    public CartController()
    {

    }
    public void DisplayCartItems()
    {
      try
      {
        Cart.GetAllCartItems();
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void IncrementProduct(int pid)
    {
      try
      {
        Cart.IncrementQuantity(pid);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void ProductRemoval(int pid)
    {
      try
      {
        Cart.RemoveProdcut(pid);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void TotalProduct(int pid)
    {
      try
      {
        Cart.TotalProducts();
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void FullAmount()
    {
      try
      {
        Cart.TotalAmount();
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }

  }
}