using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SecurePassword.Domain;
using SecurePassword.Shared;

namespace SecurePassword.API;


[ApiController]
[Route("[controller]")]
public class ApiController : ControllerBase
{
    public readonly IPasswordHandler passwordHandler;
    public ApiController(IPasswordHandler passwordHandler)
    {
        this.passwordHandler = passwordHandler;
    }

    [HttpPost]
    
    [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
    public ActionResult<List<string>> Post([FromBody] SecurePasswordRequest request)
    {
        var failures = passwordHandler.validatePass(request.Password);

        if (failures.Count == 0)
        {
            return NoContent();
        }
        else
        {
            return failures;
        }

    }
}
