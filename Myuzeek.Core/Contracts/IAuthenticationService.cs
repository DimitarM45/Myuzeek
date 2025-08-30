namespace Myuzeek.Core.Contracts;

using API.Models;

public interface IAuthenticationService
{
    Task<bool> RegisterUser(RegisterUserRequest request, CancellationToken ct);
}
