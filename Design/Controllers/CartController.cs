namespace Controllers;

using static System.Console;
using Models;
using DTOs;
using Services;

public class CartController
{
  private readonly ICartService _service;

  public CartController(ICartService service)
  {
    _service = service;
  }

  //POST /api/cart
  public async Task<Product> AddItemAsync(CartRequest request, User CurrentUser)
  {
    var task = await _service.AddItemAsync(request, CurrentUser);
    return task;
  }
  //PUT /api/cart/{id}
  public async Task<Product> IncrementItemAsync(int id, User CurrentUser)
  {
    var task = await _service.IncrementItemAsync(id, CurrentUser);
    return task;
  }
  //PUT /api/cart/{id}
  public async Task<Product> DecrementItemAsync(int id, User CurrentUser)
  {
    var task = await _service.DecrementItemAsync(id, CurrentUser);
    return task;
  }
  //DELETE /api/cart/{id}
  public async Task<bool> RemoveItemAsync(int id)
  {
    return await _service.RemoveItemAsync(id);
  }
  //GET /api/cart
  public async Task<IEnumerable<Cart>> GetAllAsync(int id, User CurrentUser)
  {
    return await _service.GetAllAsync(id, CurrentUser);
  }
}