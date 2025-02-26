using Project.Models;

namespace Project.Services
{
    public class BrazilCurrencyService : IExchange
    {
        public CurrencyModel Exchange(Task<Atributes> atributes)
        {
            return new CurrencyModel(double.Parse((atributes.Result.Amount * atributes.Result.Rate).ToString("F2")), '$');
        }
    }
}
