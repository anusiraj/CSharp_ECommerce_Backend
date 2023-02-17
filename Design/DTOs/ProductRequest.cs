namespace DTOs;

using System.ComponentModel.DataAnnotations;

public class ProductRequest
{
  [Required]
  public string Name { get; set; }
  public string Category { get; set; }
  public int Price { get; set; }
  public string Descritption { get; set; }
  public string[] Images { get; set; }
}