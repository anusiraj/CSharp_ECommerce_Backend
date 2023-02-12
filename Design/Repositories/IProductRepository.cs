namespace Repositories;

using Models;
using DTOs;

public interface IProductRepository
{
  //Create Product
  Task<Product> CreateAsync(ProductRequest request, User CurrentUser);
  //Update Product by id with objects in request
  Task<Product> UpdateAsync(int id, ProductRequest request, User CurrentUser);
  //Delete Product by Id
  Task<bool> DeleteAsync(int id, User CurrentUser);
  //Get Product by Id
  Task<Product> GetAsync(int id);
  //Get all Products
  Task<IEnumerable<Product>> GetAllAsync();
}