using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Auth.Controllers;


[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "User")] // Solo gli utenti con il ruolo "User" possono accedere
public class ProtectedController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Questo è un contenuto protetto per gli utenti autorizzati.");
    }
}