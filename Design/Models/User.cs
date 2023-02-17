namespace Models;

public class User
{
  public int ID { get; init; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Email { get; set; }
  public string? Password { get; set; }
  public string? Image { get; set; }
  public UserRole Role { get; init; }
  public List<Product>? Products;

  public User(int id, string firstname, string lastname, string email, UserRole role)
  {
    ID = id;
    FirstName = firstname;
    LastName = lastname;
    Email = email;
    Role = role;
  }

  public override string ToString()
  {
        return "User: " + FirstName + " " + LastName + "Email" + Email + "Role" + Role;
  }
}

public enum UserRole
{
  Admin,
  Customer
}


