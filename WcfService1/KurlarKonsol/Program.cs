using System;
using System.ServiceModel;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using WcfService1;

namespace RatesConsole
{ 
    class Program
    {  
        static void Main(string[] args)
        {  
            var ratesService = new RatesService();
            int value = 1; 
            var currencies = ratesService.BringCurrencies(value);
            string filePath = "kur_fiyatlari.txt";
            using (StreamWriter writer = new StreamWriter(filePath, append: true))

            {

                writer.WriteLine("Servis başlama tarihi: " + DateTime.Now);
           
                foreach (var currency in currencies)
                {
                    var rates = ratesService.GetExchangeRates(currency);

                    writer.Write(currency + ": ");

                    foreach (var rate in rates)   
                    {
                        writer.Write(rate + " ");
                    }
                    writer.WriteLine(); 
                }

                writer.WriteLine("Servis durdurulma tarihi: " + DateTime.Now); 
            
            }

            Console.WriteLine("Servis başlatıldı.");
            Console.WriteLine("Kur fiyatları kur_fiyatlari.txt dosyasına yazıldı.");
            Console.ReadLine(); 


        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                      