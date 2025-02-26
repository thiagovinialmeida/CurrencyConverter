using Project.Models;

namespace Project.Services
{
    public class EuropeCurrencyService : IExchange
    {
        public CurrencyModel Exchange(Task<Atributes> atributes)
        {
            return new CurrencyModel(double.Parse((atributes.Result.Amount * atributes.Result.Rate).ToString("F2")), '\u20AC');
        }
    }
}
