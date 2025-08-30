namespace Myuzeek.Data.Models.Contracts;

public interface IEntity : ICreatable, IDeletable
{
    public Guid Id { get; set; }
}
