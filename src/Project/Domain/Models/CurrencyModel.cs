namespace Project.Models
{
    public class CurrencyModel
    {
        public double TotalAmount { get; set; }
        public char CurrencySymbol { get; set; }

        public CurrencyModel(double totalAmount, char currencySymbol)
        {
            TotalAmount = totalAmount;
            CurrencySymbol = currencySymbol;
        }
    }
}
