namespace Myuzeek.Core.Services;

using Enums;
using Contracts;
using Response_Models;

using Data.Models;

using API.Models.Request_Models;

using Microsoft.AspNetCore.Identity;

using System.Threading;
using System.Threading.Tasks;

public class AuthenticationService : IAuthenticationService
{
    private UserManager<ApplicationUser> _userManager;
    private SignInManager<ApplicationUser> _signInManager;

    public AuthenticationService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<BaseResponseModel<string>> RegisterUserAsync(RegisterUserRequest request, CancellationToken ct)
    {
        IdentityResult result = await _userManager.CreateAsync(new() { Email = request.Email }, request.Password);

        if (!result.Succeeded)
            return new(false, ErrorCode.DefaultError, result.ToString());

        return new(true, ErrorCode.OK);
    }

    public async Task<BaseResponseModel<string>> SignInUserAsync(LogInUserRequest request, CancellationToken ct)
    {
        ApplicationUser? user = null;

        if (string.IsNullOrEmpty(request.Username))
            user = await _userManager.FindByEmailAsync(request.Email!);

        else
            user = await _userManager.FindByNameAsync(request.Username);

        if (user is null)
            return new(false, ErrorCode.UserNotFound, ErrorMessages.Messages[ErrorCode.UserNotFound]);

        SignInResult result = await _signInManager.PasswordSignInAsync(user, request.Password, true, true);

        if (!result.Succeeded)
            return new(false, ErrorCode.UserCouldNotBeSignedIn, ErrorMessages.Messages[ErrorCode.UserCouldNotBeSignedIn]);
            
        return new(true, ErrorCode.OK);
    }
}
