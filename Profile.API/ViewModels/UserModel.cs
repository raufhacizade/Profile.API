
using System.ComponentModel.DataAnnotations;

namespace Profile.API.ViewModels
{
  public class UserModel
  {
    [Required]
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
  }
}
