using Profile.Base.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Profile.API.Models
{
  public class User : IBaseEntity, ITrackCreate
  {
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedOn { get; set; }
  }
}
