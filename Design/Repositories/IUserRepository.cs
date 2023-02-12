namespace Repositories;

using Models;
using DTOs;

public interface IUserRepository
{
  //Create User
  Task<User> CreateAsync(UserRequest request);
  //Update User by id with objects in request
  Task<User> UpdateAsync(int id, UserRequest request);
  //Delete User by Id
  Task<bool> DeleteAsync(int id);
  //Get current User by id
  Task<User> GetAsync(int id);
}