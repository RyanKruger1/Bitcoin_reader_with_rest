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
            dynamic stuff = JsonConvert.DeserializeObject(value);
            dynamic data = stuff.data;
            string []values = data.Split(','); 


          
                
            return value;
        }


    }
}
