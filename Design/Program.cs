using static System.Console;
using System;
using Enums.UserRole;
using Models.UserModel;
using Models.ProductModel;

using Controllers.UserController;
using Controllers.ProductController;
using Controllers.CategoryController;
using Controllers.CartController;

namespace Programe
{
  class Programe
  {
    public static void Main(string[] args)
    {
      // var usermodel = new User();
      var userController = new UserController();
      userController.DisplayAllUser();
      userController.DisplaySingleUserById(3);
      userController.DisplayUserByEmail("anu@123");
      userController.DisplaUserRole(3);
      userController.CreateUser(new User
      {
        Id = 4,
        FirstName = "Ishal ",
        LastName = "Anas",
        Email = "ishal.anas@gmail.com",
        Password = "ishal@123",
        Image = "https://ibb.co/dJs620K",
        Role = UserRole.Customer
      });
      userController.UpdateUser(3);
      userController.DeleteUser(3);

      var productController = new ProductController();
      productController.DisplayAllProducts();
      productController.DisplayProductById(4);
      productController.DisplayProductByName("ABC");
      productController.SortProductByPrice();
      productController.ProductQuantity(2);
      productController.CreateNewProduct(new Product
      {
        PId = 4,
        PName = "HIJ",
        PCategory = "Shoe",
        PPrice = 100,
        PDescritption = "HIJ in Shoe Category",
        PImages = new string[] { "https://ibb.co/dJs620K", "https://ibb.co/dJs620K", "https://ibb.co/dJs620K" },
        PQuantity = 100
      });
      productController.UpdateExistingProduct(1);
      productController.DeleteExistingProduct(1);

      var categoryController = new CategoryController();

      var cartController = new CartController();
    }
  }
}

