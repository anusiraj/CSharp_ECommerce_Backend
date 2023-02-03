using static System.Console;
using Enums.UserRole;
using Models.UserModel;

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
        User.GetAllUser();
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
        User.GetUserById(id);
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
        User.GetUserByEmail(email);
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
        User.GetUserRole(id);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
        throw;
      }
    }
    public void CreateUser(User data)
    {
      try
      {
        User.CreateUser(data);
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
        User.UpdateUser(id);
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
        User.DeleteUser(id);
      }
      catch (Exception e)
      {
        WriteLine(e.Message);
      }
    }
  }

}