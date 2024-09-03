using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    public class RatesService : IRatesService
    {
        public List<double> GetExchangeRates(string rateType)
        {
            Random randomRate = new Random();
            List<double> listofRates = new List<double>();
            for (var i = 0; i < 15; i++)
            {
                listofRates.Add(randomRate.NextDouble() + 2);
            }
            return listofRates;
        }


        public List<string> BringCurrencies(int value)
        {
            List<string> Currencies = new List<string>();
            Currencies.Add("MANAT");
            Currencies.Add("EURO");
            Currencies.Add("DOLAR");
            Currencies.Add("POUND");
            return Currencies;
        }
    }
}
