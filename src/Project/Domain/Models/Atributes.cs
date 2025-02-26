namespace Project.Models
{
    public class Atributes
    {
        public double Amount { get; set; }
        public string CurrentCurrency { get; set; }
        public string ExchangeCurrency { get; set; }
        public double Rate { get; set; }

        public Atributes(double amount, string currentCurrency, string exchangeCurrency, double rate)
        {
            Amount = amount;
            CurrentCurrency = currentCurrency;
            ExchangeCurrency = exchangeCurrency;
            Rate = rate;
        }
    }
}
