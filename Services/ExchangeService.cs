using CurrencyConverter.Models;

namespace CurrencyConverter.Services
{
    public class ExchangeService
    {
        private IExchange _exchange;
        public ExchangeService(IExchange exchange)
        {
            _exchange = exchange;
        }

        public CurrencyModel Res(double amount, string from, string to, double rate)
        {
            return _exchange.Exchange(new Atributes(amount, from, to, rate));
        }
    }
}
