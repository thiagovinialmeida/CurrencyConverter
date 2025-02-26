using Project.Models;

namespace Project.Services
{
    public interface IExchange
    {
        CurrencyModel Exchange(Task<Atributes> atributes);
    }
}
