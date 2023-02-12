namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;
public class CartRequest
{
    [Required]
    public Product Product { get; set; }
}