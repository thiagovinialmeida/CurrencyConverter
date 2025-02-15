using CurrencyConverter.Models;

namespace CurrencyConverter.Services
{
    public interface IExchange
    {
        CurrencyModel Exchange(Task<Atributes> atributes);
    }
}
