using CurrencyConverter.Models;

namespace CurrencyConverter.Services
{
    public interface IExchange
    {
        CurrencyModel Exchange(Atributes atributes);
    }
}
