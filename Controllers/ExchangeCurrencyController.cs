using CurrencyConverter.Services;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeCurrencyController : ControllerBase
    {
        [HttpGet("{amount}/{from}/{to}")]
        public IActionResult Get(double amount, string from, string to)
        {
            switch (to.ToLower())
            {
                case "brl":
                    {
                        return Ok(new ExchangeService(new BrazilCurrencyService()).Res(amount, from, to));
                    }
                case "usd":
                    {
                        return Ok(new ExchangeService(new EUACurrencyService()).Res(amount, from, to));
                    }
                case "eur":
                    {
                        return Ok(new ExchangeService(new EuropeCurrencyService()).Res(amount, from,to));
                    }
                default:
                    {
                        return NotFound();
                    }
            }
        }
    }
}
