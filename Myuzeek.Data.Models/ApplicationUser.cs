namespace Myuzeek.Data.Models;

using Contracts;

using System;

using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser<Guid>, ICreatable, IDeletable
{
    public string? DisplayName { get; set; }

    public string? Bio { get; set; }

    public string? Pronouns { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? DeletedOn { get; set; }
}
