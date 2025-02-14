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
            switch (to.ToLower())
            {
                case "brl":
                    {
                        return Ok(new ExchangeService(new BrazilCurrencyService()).Res(amount, from, to, rate));
                    }
                case "usd":
                    {
                        return Ok(new ExchangeService(new EUACurrencyService()).Res(amount, from, to, rate));
                    }
                case "eur":
                    {
                        return Ok(new ExchangeService(new EuropeCurrencyService()).Res(amount, from, to, rate));
                    }
                default:
                    {
                        return NotFound();
                    }
            }
        }
    }
}
