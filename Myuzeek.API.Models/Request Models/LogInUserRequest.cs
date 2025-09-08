using System.ComponentModel.DataAnnotations;

namespace Myuzeek.API.Models.Request_Models;

public class LogInUserRequest
{
    [EmailAddress]
    public string? Email { get; set; }

    public string? Username { get; set; }

    [Required]
    public required string Password { get; set; }

    public bool RememberMe { get; set; } = false;
}
