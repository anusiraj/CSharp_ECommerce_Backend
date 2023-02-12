namespace Repositories;

using Models;
using DTOs;

public interface ICategoryRepository
{
  //Create Category
  Task<Category> CreateAsync(CategoryRequest request, User CurrentUser);
  //Update Category by id with objects in request
  Task<Category> UpdateAsync(int id, CategoryRequest request, User CurrentUser);
  //Delete Category by Id
  Task<bool> DeleteAsync(int id, User CurrentUser);
  //Get Category by Id
  Task<Category> GetAsync(int id);
  //Get all Category by Id
  Task<IEnumerable<Category>> GetAllAsync(int id);
}