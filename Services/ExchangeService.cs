using CurrencyConverter.Models;

namespace CurrencyConverter.Services
{
    public class ExchangeService
    {
        public CurrencyModel Exchange(double amount, string from, string to, double rate)
        {
            char x;
            if(to.ToUpper() == "EUR")
            {
                x = '\u20AC';
                return new CurrencyModel(double.Parse((amount * rate).ToString("F2")), x);
            }
            x = '$';
            return new CurrencyModel(double.Parse((amount * rate).ToString("F2")), x);
        }
    }
}
