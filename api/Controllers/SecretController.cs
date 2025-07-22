using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace api.Controllers
{
    [ApiController]
    [Route("api/secrets")]
    public class SecretController : ControllerBase
    {
        private readonly AppSettings _appSettings;

        public SecretController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        public IActionResult GetSecret()
        {
            return Ok(new { Secret = _appSettings.JwtSecret, Expiry = int.Parse(_appSettings.JwtExpiryMinutes) });
        }
    }
}