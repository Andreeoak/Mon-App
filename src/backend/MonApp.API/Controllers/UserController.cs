using Microsoft.AspNetCore.Mvc;
using MonApp.Communication.Requests;
using MonApp.Communication.Responses;
namespace MonAPP.Controllers;

[Route("[controller]")]
[ApiController]

public class UserController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterdUser),StatusCodes.Status201Created)]
    public IActionResult Register(RequestRegisterUser Request)
    {
        return Created();
    }
}