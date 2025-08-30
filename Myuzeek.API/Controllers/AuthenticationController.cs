namespace Myuzeek.API.Controllers;

using API.Models;
using Core.Contracts;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

[ApiController]
public class AuthenticationController : BaseController
{
    private IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("account/register")]
    public async Task<IActionResult> RegisterUser(RegisterUserRequest request, CancellationToken ct)
    {
        return Ok(_authenticationService.RegisterUser(request, ct));
    }

    [HttpPost("account/login")]
    public async Task<IActionResult> LoginUser()
    {

    }

    [Authorize]
    [HttpDelete("account/{id}")]
    public async Task<IActionResult> DeleteUser()
    {

    }
}
