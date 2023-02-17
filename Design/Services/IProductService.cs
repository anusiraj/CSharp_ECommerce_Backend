namespace Services;

using Models;
using DTOs;

public interface IProductService
{
  //Create Product
  Task<Product> CreateAsync(ProductRequest request, User CurrentUser);

  //Update Product by id with objects in request
  Task<Product> UpdateAsync(int id, ProductRequest request, User CurrentUser);

  //Delete Product by Id
  Task<bool> DeleteAsync(int id, User CurrentUser);

  //Get all Product by Id
  Task<IEnumerable<Product>> GetAllAsync();

  //Get Product by Id
  Task<Product> GetAsync(int id);

  //Get the searched product by name if true else return not available
  Task<(bool, Product)> Search(string name);

  //Get featured Products(let it be first 15 products)
  Task<IEnumerable<Product>> GetFeatured(int count);
  
  //Sort products by price
  Task<IEnumerable<Product>> Sort(int price);
}