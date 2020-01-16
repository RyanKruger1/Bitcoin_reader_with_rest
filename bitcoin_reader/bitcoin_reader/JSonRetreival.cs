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
            using (StreamReader r = new StreamReader(value))
            {
                string json = r.ReadToEnd();
                
            return null;
        }
    }

   
}
