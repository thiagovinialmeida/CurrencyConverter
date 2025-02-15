using CurrencyConverter.Models;

namespace CurrencyConverter.Services
{
    public class BrazilCurrencyService : IExchange
    {
        public CurrencyModel Exchange(Task<Atributes> atributes)
        {
            return new CurrencyModel(double.Parse((atributes.Result.Amount * atributes.Result.Rate).ToString("F2")), '$');
        }
    }
}
