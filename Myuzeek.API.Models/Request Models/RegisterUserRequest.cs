using System.ComponentModel.DataAnnotations;

namespace Myuzeek.API.Models.Request_Models;

public class RegisterUserRequest
{
    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    public required string Password { get; set; }
}
