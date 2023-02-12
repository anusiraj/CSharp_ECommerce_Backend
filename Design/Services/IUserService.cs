namespace Services;

using Models;
using DTOs;

public interface IUserService
{
  //For creating User
  Task<User> CreateAsync(UserRequest request);
  //Update User by id with objects in request
  Task<User> UpdateAsync(int id, UserRequest request);
  //Delete User by Id
  Task<bool> DeleteAsync(int id);
  //Get current User by ID
  Task<User> GetAsync(int id);
  //Check the role of the User by Id
  Task<User> GetRoleAsync(int id);
}