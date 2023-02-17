namespace Services;

using Models;
using DTOs;

public interface ICartService
{
  //Add to cart
  Task<Product> AddItemAsync(CartRequest request, User CurrentUser);

  //Increment cart item by id
  Task<Product> IncrementItemAsync(int id, User CurrentUser);

  //Decrement cart item by id
  Task<Product> DecrementItemAsync(int id, User CurrentUser);

  //Delete cart item by Id
  Task<bool> RemoveItemAsync(int id);
  
  //Get all cart items by Id
  Task<IEnumerable<Cart>> GetAllAsync(int id, User CurrentUser);
}