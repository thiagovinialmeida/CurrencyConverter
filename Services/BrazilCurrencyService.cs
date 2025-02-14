using CurrencyConverter.Models;

namespace CurrencyConverter.Services
{
    public class BrazilCurrencyService : IExchange
    {
        public CurrencyModel Exchange(Atributes atributes)
        {
            return new CurrencyModel(atributes.Amount * atributes.Rate, '$');
        }
    }
}
