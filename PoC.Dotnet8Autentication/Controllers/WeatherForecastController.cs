using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PoC.Dotnet8Autentication.Controllers
{
    [ApiController]
    [Route("[controller]"), Authorize]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(UserManager<IdentityUser> userManager, ILogger<WeatherForecastController> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var user = _userManager.GetUserAsync(User); 

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                User = user.Id
            })
            .ToArray();
        }
    }
}
