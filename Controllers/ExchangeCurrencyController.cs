using CurrencyConverter.Services;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeCurrencyController : ControllerBase
    {
        [HttpGet("{amount}/{from}/{to}/{rate}")]
        public IActionResult Get(double amount, string from, string to, double rate)
        {
            return Ok(new ExchangeService().Exchange(amount, from, to, rate));
        }
    }
}
