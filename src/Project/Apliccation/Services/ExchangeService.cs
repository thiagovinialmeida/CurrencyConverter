using Project.Models;
using Project.Repositories;
namespace Project.Services
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
            return _exchange.Exchange(new RateRepository().GetRate(to+"-"+from, amount));
        }
    }
}
