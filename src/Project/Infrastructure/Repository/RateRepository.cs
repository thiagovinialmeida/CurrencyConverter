using Project.Models;
namespace Project.Repositories
{
    public class RateRepository
    {
        static HttpClient _client = new HttpClient();
        public async Task<Atributes> GetRate(string currency, double amount)
        {
            HttpResponseMessage response =
                await _client.GetAsync(
                    $"https://economia.awesomeapi.com.br/json/last/{currency.ToUpper()}");
            string rtn = await response.Content.ReadAsStringAsync();
            
            string[] obj = rtn.Split(',');

            string[] currentCurrency = obj[0].Split(':');
            string[] exchangeCurrency = obj[1].Split(':');
            string[] rateHigh = obj[3].Split(':');
            string[] rateLow = obj[4].Split(':');

            string txt = rateHigh[1].Replace('"', ' ');
            string txt2 = rateLow[1].Replace('"', ' ');
            double x = double.Parse(txt.Replace('.', ','));
            double y = double.Parse(txt2.Replace('.', ','));
            
            double average = (x + y) / 2;
            
            return new Atributes(amount, currentCurrency[1], exchangeCurrency[1], double.Parse(average.ToString("F2"))); 
        }
    }
}
