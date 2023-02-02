using static System.Console;
using System;
using Enums.UserRole;
using Models.User;
using Controllers.UserController;

namespace Programe
{
  class Programe
  {
    public static void Main(string[] args)
    {
      var usermodel = new UserModel();
      var userController = new UserController();
      userController.DisplayAllUser();
      userController.DisplaySingleUserById(3);
      userController.DisplayUserByEmail("anu@123");
      userController.DisplaUserRole(3);
      userController.CreateUser(new UserModel{Id = 4, FirstName = "Ishal ",LastName = "Anas", Email ="ishal.anas@gmail.com", 
            Password = "ishal@123", Image = "https://ibb.co/dJs620K", Role = UserRole.Customer});
      userController.UpdateUser(3);
      userController.DeleteUser(3);
    }
  }
}

