namespace Myuzeek.Data.Models.Contracts;

public interface IDeletable
{
    public DateTime? DeletedOn { get; set; }
}
