namespace Myuzeek.API.Controllers;

using Models.Request_Models;

using Core.Enums;
using Core.Contracts;
using Core.Response_Models;

using Microsoft.AspNetCore.Mvc;


public class AuthenticationController : BaseController
{
    private IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService, ILogger<AuthenticationController> logger)
        : base(logger)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("account/register")]
    public async Task<IActionResult> RegisterUser(RegisterUserRequest request, CancellationToken ct)
    {
        try
        {
            BaseResponseModel<string> response = await _authenticationService.RegisterUserAsync(request, ct);

            if (response.Success)
                return Ok(response.ResultObject);

            if (response.ResultCode == ErrorCode.UserAlreadyExists)
                return StatusCode(403, response.ResultMessage);

            return BadRequest(response.ResultMessage);
        }
        catch (Exception)
        {
            return Problem(ErrorMessages.Messages[ErrorCode.DefaultError], statusCode: 500);
        }
    }

    //[HttpPost("account/login")]
    //public async Task<IActionResult> LoginUser(CancellationToken ct)
    //{

    //}

    //[Authorize]
    //[HttpDelete("account/{id}")]
    //public async Task<IActionResult> DeleteUser([FromRoute] string id, CancellationToken ct)
    //{

    //}
}
