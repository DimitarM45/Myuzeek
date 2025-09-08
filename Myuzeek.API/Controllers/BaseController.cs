namespace Myuzeek.API.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/")]
public class BaseController : ControllerBase
{
    protected ILogger _logger;

    public BaseController(ILogger<BaseController> logger)
    {
        _logger = logger;
    }
}
