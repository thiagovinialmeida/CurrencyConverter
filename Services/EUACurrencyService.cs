﻿using CurrencyConverter.Models;

namespace CurrencyConverter.Services
{
    public class EUACurrencyService : IExchange
    {
        public CurrencyModel Exchange(Task<Atributes> atributes)
        {
            return new CurrencyModel(double.Parse((atributes.Result.Amount * atributes.Result.Rate).ToString("F2")), '$');
        }
    }
}
