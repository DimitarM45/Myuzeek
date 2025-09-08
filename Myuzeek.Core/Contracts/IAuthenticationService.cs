namespace Myuzeek.Core.Contracts;

using Enums;
using Response_Models;

using API.Models.Request_Models;

public interface IAuthenticationService
{
    Task<BaseResponseModel<string>> RegisterUserAsync(RegisterUserRequest request, CancellationToken ct);

    Task<BaseResponseModel<string>> SignInUserAsync(LogInUserRequest request, CancellationToken ct);
}
