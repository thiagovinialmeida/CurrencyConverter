using CurrencyConverter.Models;
using CurrencyConverter.Repository;
namespace CurrencyConverter.Services
{
    public class ExchangeService
    {
        private IExchange _exchange;
        public ExchangeService(IExchange exchange)
        {
            _exchange = exchange;
        }

        public CurrencyModel Res(double amount, string from, string to)
        {
            return _exchange.Exchange(new RateService().GetRate(to+"-"+from, amount));
        }
    }
}
