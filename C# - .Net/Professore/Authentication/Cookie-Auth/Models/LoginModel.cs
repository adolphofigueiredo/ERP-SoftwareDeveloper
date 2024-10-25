namespace Cookie_Auth.Models;

public class LoginModel
{
    public string Username { get; set; }
    public string Password { get; set; }
    public bool RememberMe { get; set; } // Per il cookie persistente
}