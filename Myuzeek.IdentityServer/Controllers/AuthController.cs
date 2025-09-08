namespace Myuzeek.IdentityServer.Controllers;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components;

[Route("authentication")]
public class AuthController : BaseController
{
    private SignInManager<IdentityUser> _signInManager;
    private UserManager<IdentityUser> _userManager;

    public AuthController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }
}
