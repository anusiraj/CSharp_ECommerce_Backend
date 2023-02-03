using static System.Console;
using System;
using Enums.UserRole;
namespace Models.UserModel
{
  public class User
  {
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Image { get; set; }
    public UserRole Role { get; init; }
    public List<User> UserData;

    public User(int id, string firstname, string lastname, string email, string password, string image, UserRole role)
    {
      Id = id;
      FirstName = firstname;
      LastName = lastname;
      Email = email;
      Password = password;
      Image = image;
      Role = role;
    }
    public User()
    {
    }

    public static void GetAllUser()
    {
        var users = new List<User>{
            new User{Id = 1, FirstName = "Anu ",LastName = "Siraj", Email ="anu.jencir@gmail.com", 
            Password = "anu@123", Image = "https://ibb.co/dJs620K", Role = UserRole.Customer},
            new User{Id = 2, FirstName = "Shinu ", LastName = "Siraj", Email ="shinu.anas@gmail.com", 
            Password = "shinu@123", Image = "https://ibb.co/dJs620K", Role = UserRole.Customer},
            new User{Id = 3, FirstName = "Shamon ", LastName = "Siraj", Email ="shamon.siraj@gmail.com", 
            Password = "shamon@123", Image = "https://ibb.co/dJs620K", Role = UserRole.Customer},
            };
		
		foreach(var user in users)
			Console.WriteLine(user.Id + ", " +user.FirstName+user.LastName +","+
            user.Email+ ","+ user.Password+ ","+ user.Image+ ","+user.Role);
    }
    public static void GetUserById(int id)
    {
      WriteLine("Return user details found by id");
    }
    public static void GetUserByEmail(string email)
    {
      WriteLine("Return user details found by email");
    }
    public static void GetUserRole(int id)
    {
      WriteLine("Return user role found by id");
    }
    public static void CreateUser(User data)
    {
        WriteLine("Creates User");
    }
     public static void UpdateUser(int id)
    {
        WriteLine("Updates User");
    }
     public static void DeleteUser(int id)
    {
        WriteLine("Deletes User");
    }
    public override string ToString()
    {
      return "User: " + FirstName + " " + LastName + "Email" + Email + "Role" + Role;
    }
  }
}

