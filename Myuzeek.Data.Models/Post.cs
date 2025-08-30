namespace Myuzeek.Data.Models;

using Contracts;

using static Common.ValidationConstants;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Post : IEntity
{
    public Guid Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? DeletedOn { get; set; }

    [MaxLength(MAX_POST_CAPTION_LENGTH)]
    public string? Caption { get; set; }

    [MaxLength(MAX_POST_CONTENT_LENGTH)]
    public string? Content { get; set; }

    public Guid ApplicationUserId { get; set; }

    [ForeignKey(nameof(ApplicationUserId))]
    public ApplicationUser Author { get; set; } 
}
