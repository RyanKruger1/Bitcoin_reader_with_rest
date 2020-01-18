using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitcoin_reader
{
    class JSonRetreival
    {

        string price { get; set; }
       public static Dictionary<string, string> coinAndPrice = new Dictionary<string, string>();

        public void FryTheJson(string value)
        {
            dynamic array = JsonConvert.DeserializeObject(value);
            dynamic data = array.data;

            foreach (var item in data)
            {
                dynamic currentData = item;
                
                string name = currentData.name;
                
                dynamic quote = currentData.quote;
                
                dynamic usdQuote = quote.USD;

                string one = usdQuote.percent_change_1h;
                string day = usdQuote.percent_change_24h;
                string week = usdQuote.percent_change_7d;
                string two = usdQuote.precent_change_2h;

                coinAndPrice.Add(name+ "_percent_change_1h",one);
                coinAndPrice.Add(name + "_percent_change_24h", day);
               // coinAndPrice.Add("percent_change_2h",two);
                coinAndPrice.Add(name + "_percent_change_7d", week);

                price = usdQuote.price;
                coinAndPrice.Add(name,price);
            }
           
        }

        


    }
}
