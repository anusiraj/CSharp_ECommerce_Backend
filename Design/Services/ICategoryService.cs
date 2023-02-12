namespace Services;

using Models;
using DTOs;

public interface ICategoryService
{
  //Create Category
  Task<Category> CreateAsync(CategoryRequest request, User CurrentUser);
  //Update Category by id with objects in request
  Task<Category> UpdateAsync(int id, CategoryRequest request, User CurrentUser);
  //Delete Category by Id
  Task<bool> DeleteAsync(int id, User CurrentUser);
  //Get Category by Id
  Task<Category> GetAsync(int id);
  //Get all Category
  Task<IEnumerable<Category>> GetAllAsync();
  //Get all Products in that Category by category_id
  Task<IEnumerable<Product>> Products(int id);
}