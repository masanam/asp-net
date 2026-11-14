using System.Runtime.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new {message ="Welcome to Task manager API", version = "1.0"});
    }
}

