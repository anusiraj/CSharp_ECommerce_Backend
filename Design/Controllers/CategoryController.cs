namespace Controllers;

using Models;
using DTOs;
using Services;

public class CategoryController
{
  private readonly ICategoryService _service;

  public CategoryController(ICategoryService service)
  {
        _service = service;
  }

  //POST /api/category
  public async Task<Category> CreateAsync(CategoryRequest request, User CurrentUser)
  {
        var task = await _service.CreateAsync(request, CurrentUser);
        return task;
  }

  //PUT /api/category/{id}
  public async Task<Category> UpdateAsync(int id, CategoryRequest request, User CurrentUser)
  {
        return await _service.UpdateAsync(id, request, CurrentUser);
  }

  //DELETE /api/category/{id}
  public async Task<bool> DeleteAsync(int id, User CurrentUser)
  {
        return await _service.DeleteAsync(id, CurrentUser);
  }

  //GET /api/category/{id}
  public async Task<Category> GetAsync(int id)
  {
        return await _service.GetAsync(id);
  }

  //GET /api/category
  public async Task<IEnumerable<Category>> GetAllAsync()
  {
        return await _service.GetAllAsync();
  }
}