namespace Controllers;

using Models;
using DTOs;
using Services;

public class ProductController
{
  private readonly IProductService _service;

  public ProductController(IProductService service)
  {
        _service = service;
  }

  //POST /api/product
  public async Task<Product> CreateAsync(ProductRequest request, User CurrentUser)
  {
        var task = await _service.CreateAsync(request, CurrentUser);
        return task;
  }

  //PUT /api/product/{id}
  public async Task<Product> UpdateAsync(int id, ProductRequest request, User CurrentUser)
  {
        return await _service.UpdateAsync(id, request, CurrentUser);
  }

  //DELETE /api/product/{id}
  public async Task<bool> DeleteAsync(int id, User CurrentUser)
  {
        return await _service.DeleteAsync(id, CurrentUser);
  }

  //GET /api/product/{id}
  public async Task<Product> GetAsync(int id)
  {
        return await _service.GetAsync(id);
  }

  //GET /api/product
  public async Task<IEnumerable<Product>> GetAllAsync()
  {
        return await _service.GetAllAsync();
  }
}