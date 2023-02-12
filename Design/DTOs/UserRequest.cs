namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class UserRequest
{
  [Required]
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Email { get; set; }
  public string? Password { get; set; }
  public string? Image { get; set; }
  public UserRole Role { get; init; }
  public List<Product>? Products;
}