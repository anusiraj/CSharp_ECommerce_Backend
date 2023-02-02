using static System.Console;
using Enums.UserRole;
using Models.User;

namespace Controllers.UserController
{
  public class UserController
  {
    // public int Id {get; init;}
    // public string FirstName{get; set;}
    // public string LastName{get; set;}
    // public string Email{get; set;}
    // public string Password{get; set;}
    // public string Image{get; set;}
    // public UserRole Role{get; init;}
    public void DisplayAllUser()
    {
      try
      {
        UserModel.GetAllUser();
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void DisplaySingleUserById(int id)
    {
      try
      {
        UserModel.GetUserById(id);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void DisplayUserByEmail(string email)
    {
      try
      {
        UserModel.GetUserByEmail(email);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void DisplaUserRole(int id)
    {
      try
      {
        UserModel.GetUserRole(id);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void CreateUser(UserModel data)
    {
      try
      {
        UserModel.CreateUser(data);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
      }
    }
    public void UpdateUser(int id)
    {
      try
      {
        UserModel.UpdateUser(id);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
      }
    }
    public void DeleteUser(int id)
    {
      try
      {
        UserModel.DeleteUser(id);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
      }
    }
  }

}