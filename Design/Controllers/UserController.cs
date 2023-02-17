namespace Controllers;

using Models;
using DTOs;
using Services;

public class UserController
{
  private readonly IUserService _service;

  public UserController(IUserService service)
  {
        _service = service;
  }

  //POST /api/user
  public async Task<User> CreateAsync(UserRequest request)
  {
      var task = await _service.CreateAsync(request);
        return task;
  }

  //PUT /api/user/{id}
  public async Task<User> UpdateAsync(int id, UserRequest request)
  {
        return await _service.UpdateAsync(id, request);
  }

  //DELETE /api/user/{id}
  public async Task<bool> DeleteAsync(int id)
  {
        return await _service.DeleteAsync(id);
  }

  //GET /api/user/{id}
  public async Task<User> GetAsync(int id)
  {
        return await _service.GetAsync(id);
  }
}