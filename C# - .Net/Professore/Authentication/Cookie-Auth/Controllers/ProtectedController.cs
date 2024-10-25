using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cookie_Auth.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize] // Solo gli utenti autenticati possono accedere
public class ProtectedController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Questo è un contenuto protetto per gli utenti autenticati.");
    }
}