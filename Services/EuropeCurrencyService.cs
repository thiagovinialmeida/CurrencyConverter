using CurrencyConverter.Models;

namespace CurrencyConverter.Services
{
    public class EuropeCurrencyService : IExchange
    {
        public CurrencyModel Exchange(Atributes atributes)
        {
            return new CurrencyModel(atributes.Amount * atributes.Rate, '\u20AC');
        }
    }
}
