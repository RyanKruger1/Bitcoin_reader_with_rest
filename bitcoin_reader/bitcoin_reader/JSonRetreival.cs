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
        
        public string FryTheJson(string value)
        {
            dynamic array = JsonConvert.DeserializeObject(value);
            dynamic data = array.data;

            foreach (var item in data)
            {
                dynamic currentData = item;
                string name = currentData.name;

                dynamic quote = currentData.quote;
                dynamic usdQuote = quote.USD;

                string price = usdQuote.price;

            }
            return null;
        }


    }
}
