using CurrencyConverter.Models;

namespace CurrencyConverter.Services
{
    public class EUACurrencyService : IExchange
    {
        public CurrencyModel Exchange(Atributes atributes)
        {
            return new CurrencyModel(atributes.Amount * atributes.Rate, '$');
        }
    }
}
